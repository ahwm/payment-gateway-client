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

#if !NET462
        private readonly HttpClient _httpClient;
        private static readonly System.Lazy<HttpClient> _sharedHttpClient = new System.Lazy<HttpClient>(() => new HttpClient());
#endif

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

#if !NET462
        /// <summary>
        /// Initialize for use with any supported provider with a provided <see cref="HttpClient"/> for dependency injection
        /// </summary>
        /// <param name="securityKey"></param>
        /// <param name="provider"></param>
        /// <param name="httpClient"></param>
        public GatewayClient(string securityKey, GatewayProvider provider, HttpClient httpClient)
        {
            SecurityKey = securityKey;
            Provider = provider;
            _httpClient = httpClient;
        }

        /// <summary>
        /// Initialize for use with default provider (NMI) with a provided <see cref="HttpClient"/> for dependency injection
        /// </summary>
        /// <param name="securityKey"></param>
        /// <param name="httpClient"></param>
        public GatewayClient(string securityKey, HttpClient httpClient) : this(securityKey, GatewayProvider.NMI, httpClient)
        { }

        /// <summary>
        /// Initialize for use with any supported provider with a provided <see cref="HttpClient"/> for dependency injection. Please file an issue at <a href="https://github.com/ahwm/payment-gateway-client">https://github.com/ahwm/payment-gateway-client</a> if using a provider not included
        /// </summary>
        /// <param name="securityKey"></param>
        /// <param name="postUrl"></param>
        /// <param name="httpClient"></param>
        public GatewayClient(string securityKey, string postUrl, HttpClient httpClient) : this(securityKey, new GatewayProvider(postUrl), httpClient)
        { }
#endif

        private async Task<Dictionary<string, string>> MakeRequest(object model)
        {
#if NET462
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
#endif

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
#if NET462
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
#else
                HttpClient client = _httpClient ?? _sharedHttpClient.Value;
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
#endif
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
#if NET462
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
#endif

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
#if NET462
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
#else
                HttpClient client = _httpClient ?? _sharedHttpClient.Value;
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
#endif
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
