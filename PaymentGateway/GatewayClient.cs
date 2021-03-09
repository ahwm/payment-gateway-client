using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    public class GatewayClient
    {
        private GatewayProvider Provider { get; }

        private string SecurityKey { get; }

        public GatewayClient(string securityKey, GatewayProvider provider)
        {
            SecurityKey = securityKey;
            Provider = provider;
        }
    }
}
