using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    public class GatewayProvider
    {
        public string PostUrl { get; }

        public static GatewayProvider NetworkMerchants { get; } = new GatewayProvider("https://secure.networkmerchants.com/api/transact.php");
        public static GatewayProvider BottomLinePayments { get; } = new GatewayProvider("https://secure.bottomlinegateway.com/api/transact.php");
        public static GatewayProvider CyoGate { get; } = new GatewayProvider("https://secure.cyogate.net/api/transact.php");
        public static GatewayProvider EPNA { get; } = new GatewayProvider("https://epna.transactiongateway.com/api/transact.php");
        public static GatewayProvider PayScout { get; } = new GatewayProvider("https://secure.payscout.com/api/transact.php");

        public GatewayProvider(string postUrl)
        {
            PostUrl = postUrl;
        }
    }
}
