using PaymentGateway.Helpers;
using PaymentGateway.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Xml.Linq;

namespace PaymentGateway
{
    public partial class GatewayClient
    {
        public delegate void RequestStartedEventHandler(object sender, GatewayEventArgs e);
        public event RequestStartedEventHandler RequestStarted;
        public delegate void RequestCompletedEventHandler(object sender, GatewayEventArgs e);
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
        public GatewayClient(string securityKey) : this(securityKey, GatewayProvider.NetworkMerchants)
        { }

        /// <summary>
        /// Initialize for use with any supported provider
        /// </summary>
        /// <param name="securityKey"></param>
        /// <param name="postUrl"></param>
        public GatewayClient(string securityKey, string postUrl) : this(securityKey, new GatewayProvider(postUrl))
        { }

        private Dictionary<string, string> MakeRequest(object model)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Dictionary<string, string> Values = new Dictionary<string, string>();
            Values.Add("security_key", SecurityKey);

            var attributes = AttributeHelper.GetAttributes(model);
            foreach (var kv in attributes)
                Values.Add(kv.Key, kv.Value);

            Dictionary<string, string> resp = new Dictionary<string, string>();
            using (HttpClient client = new HttpClient())
            {
                using (var postContent = new FormUrlEncodedContent(Values))
                using (HttpResponseMessage response = client.PostAsync(Provider.PostUrl + "/transact.php", postContent).Result)
                {
                    response.EnsureSuccessStatusCode();
                    using (HttpContent content = response.Content)
                    {
                        string result = content.ReadAsStringAsync().Result;
                        var values = HttpUtility.ParseQueryString(result);
                        foreach (var key in values.AllKeys)
                            resp.Add(key, values[key]);
                    }
                }
            }

            return resp;
        }
    }
}
