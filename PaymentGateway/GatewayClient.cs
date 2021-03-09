using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    public class GatewayClient
    {
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
    }
}
