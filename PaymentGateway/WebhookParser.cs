using PaymentGateway.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace PaymentGateway
{
    /// <summary>
    /// Methods to validate webhook events
    /// </summary>
    public static class WebhookParser
    {
        /// <summary>
        /// Verify the webhook signature
        /// </summary>
        /// <param name="body">Webhook POST body</param>
        /// <param name="signingKey">Signing Key from gateway control panel</param>
        /// <param name="webhookSignature">Contents of "webhook-Signature" header</param>
        /// <returns></returns>
        /// <exception cref="GatewayException">If "webhook-Signature" header is missing nonce (t= paramenter) or signature (s= parameter)</exception>
        static public WebhookResponse ParseWebhookData(string body, string signingKey, string webhookSignature)
        {
            string[] sig = webhookSignature.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (!sig[0].StartsWith("t="))
                throw new GatewayException("Webhook Error: Missing nonce");
            if (!sig[1].StartsWith("s="))
                throw new GatewayException("Webhook Error: Missing signature");
            string nonce = sig[0].Substring(2), signature = sig[1].Substring(2);
            HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(signingKey));
            return new WebhookResponse
            {
                Data = (WebhookData)JsonSerializer.Deserialize(body, typeof(WebhookData), new JsonSerializerOptions { IncludeFields = true }),
                IsValid = signature == ByteToString(hmac.ComputeHash(Encoding.UTF8.GetBytes(nonce + "." + body))),
                Nonce = nonce
            };
        }

        static string ByteToString(byte[] buff)
        {
            var sbinary = new StringBuilder();
            for (int i = 0; i < buff.Length; i++)
                sbinary.Append(buff[i].ToString("x2")); /* hex format */
            return sbinary.ToString();
        }
    }
}
