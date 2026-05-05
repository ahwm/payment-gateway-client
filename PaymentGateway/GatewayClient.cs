using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using PaymentGateway.Helpers;
using PaymentGateway.Models;
using PaymentGateway.Query.Models;

namespace PaymentGateway
{
    /// <summary>
    /// Primary client for interacting with the gateway
    /// </summary>
    public partial class GatewayClient
    {
        /// <summary>
        /// Event when a request is initiated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void RequestStartedEventHandler(object sender, GatewayEventArgs e);
        /// <summary>
        /// Invoked when request is initiated
        /// </summary>
        public event RequestStartedEventHandler RequestStarted;
        /// <summary>
        /// Event when a request is completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void RequestCompletedEventHandler(object sender, GatewayEventArgs e);
        /// <summary>
        /// Invoked when request is competed
        /// </summary>
        public event RequestCompletedEventHandler RequestCompleted;

        private GatewayProvider Provider { get; }
        private string SecurityKey { get; }

        /// <summary>
        /// Initialize for use with any supported provider
        /// </summary>
        /// <param name="securityKey"></param>
        /// <param name="provider"></param>
        public GatewayClient(string securityKey, GatewayProvider provider)
        {
            SecurityKey = securityKey;
            Provider = provider;
        }

        /// <summary>
        /// Initialize for use with default provider (NMI)
        /// </summary>
        /// <param name="securityKey"></param>
        public GatewayClient(string securityKey) : this(securityKey, GatewayProvider.NMI)
        { }

        /// <summary>
        /// Initialize for use with any supported provider. Please file an issue at <a href="https://github.com/ahwm/payment-gateway-client">https://github.com/ahwm/payment-gateway-client</a> if using a provider not included
        /// </summary>
        /// <param name="securityKey"></param>
        /// <param name="postUrl"></param>
        public GatewayClient(string securityKey, string postUrl) : this(securityKey, new GatewayProvider(postUrl))
        { }

        private async Task<Dictionary<string, string>> MakeRequest(object model)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Dictionary<string, string> Values = new Dictionary<string, string>
            {
                { "security_key", SecurityKey }
            };

            var attributes = AttributeHelper.GetAttributes(model);
            foreach (var kv in attributes)
                Values.Add(kv.Key, kv.Value);

            RequestStarted?.Invoke(this, new GatewayEventArgs(Values));

            Dictionary<string, string> resp = new Dictionary<string, string>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (var postContent = new FormUrlEncodedContent(Values))
                    using (HttpResponseMessage response = await client.PostAsync(Provider.PostUrl + "/transact.php", postContent).ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();
                        using (HttpContent content = response.Content)
                        {
                            string result = await content.ReadAsStringAsync();
                            var values = HttpUtility.ParseQueryString(result);
                            foreach (var key in values.AllKeys)
                                resp.Add(key, values[key]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new GatewayException($"Unable to communicate with gateway ({Provider.PostUrl}). Ensure {nameof(Provider.PostUrl)} has a correct value and the security key is correct. See inner exception for details.", ex);
            }

            RequestCompleted?.Invoke(this, new GatewayEventArgs(resp));

            return resp;
        }

        private async Task<QueryResponse> MakeQueryRequest(object model)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Dictionary<string, string> Values = new Dictionary<string, string>
            {
                { "security_key", SecurityKey }
            };

            var attributes = AttributeHelper.GetAttributes(model);
            foreach (var kv in attributes)
                Values.Add(kv.Key, kv.Value);

            RequestStarted?.Invoke(this, new GatewayEventArgs(Values));

            var resp = new QueryResponse();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (var postContent = new FormUrlEncodedContent(Values))
                    using (HttpResponseMessage response = await client.PostAsync(Provider.PostUrl + "/query.php", postContent).ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();
                        using (HttpContent content = response.Content)
                        {
                            string result = await content.ReadAsStringAsync();
                            resp = (QueryResponse)new XmlSerializer(typeof(QueryResponse)).Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(result)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new GatewayException($"Unable to communicate with gateway ({Provider.PostUrl}). Ensure {nameof(Provider.PostUrl)} has a correct value and the security key is correct. See inner exception for details.", ex);
            }

            //RequestCompleted?.Invoke(this, new GatewayEventArgs(resp));

            return resp;
        }
    }
}
