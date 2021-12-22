using System;
using System.Security.Cryptography;
using System.Text;

namespace PaymentGateway
{
    public static class WebhookValidator
    {
        /// <summary>
        /// Verify the webhook signature
        /// </summary>
        /// <param name="body">Webhook POST body</param>
        /// <param name="signingKey">Signing Key from gateway control panel</param>
        /// <param name="webhookSignature">Contents of "webhook-Signature" header</param>
        /// <returns></returns>
        static public bool VerifyWebhook(string body, string signingKey, string webhookSignature)
        {
            string[] sig = webhookSignature.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (!sig[0].StartsWith("t="))
                throw new GatewayException("Webhook Error: Missing nonce");
            if (!sig[1].StartsWith("s="))
                throw new GatewayException("Webhook Error: Missing signature");
            string nonce = sig[0].Substring(2), signature = sig[1].Substring(2);
            HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(signingKey));
            return signature == ByteToString(hmac.ComputeHash(Encoding.UTF8.GetBytes(nonce + "." + body)));
        }

        static string ByteToString(byte[] buff)
        {
            string sbinary = "";
            for (int i = 0; i < buff.Length; i++)
                sbinary += buff[i].ToString("x2"); /* hex format */
            return sbinary;
        }
    }
}
