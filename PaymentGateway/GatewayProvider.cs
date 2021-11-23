using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    public class GatewayProvider
    {
        public string PostUrl { get; }

        public static GatewayProvider ZeroMerchant { get; } = new GatewayProvider("https://0merchant.transactiongateway.com/api");
        public static GatewayProvider AdvancedMerchantGroup { get; } = new GatewayProvider("https://secure.advancedmerchantgroupgateway.com/api");
        public static GatewayProvider AliantPayments { get; } = new GatewayProvider("https://secure.apsmerchantgateway.com/api");
        public static GatewayProvider BottomLinePayments { get; } = new GatewayProvider("https://secure.bottomlinegateway.com/api");
        public static GatewayProvider CyoGate { get; } = new GatewayProvider("https://secure.cyogate.net/api");
        public static GatewayProvider DurangoMerchantServices { get; } = new GatewayProvider("https://secure.durango-direct.com/api");
        public static GatewayProvider EasyPayDirect { get; } = new GatewayProvider("https://secure.easypaydirectgateway.com/api");
        public static GatewayProvider EPNA { get; } = new GatewayProvider("https://epna.transactiongateway.com/api");
        public static GatewayProvider MerchantGuy { get; } = new GatewayProvider("https://secure.merchantguygateway.com/api");
        public static GatewayProvider MerchantOne { get; } = new GatewayProvider("https://secure.merchantonegateway.com/api");
        public static GatewayProvider NationalProcessing { get; } = new GatewayProvider("https://secure.nationalprocessinggateway.com/api");
        public static GatewayProvider NetworkMerchants { get; } = new GatewayProvider("https://secure.networkmerchants.com/api");
        public static GatewayProvider Vericheck { get; } = new GatewayProvider("https://vericheck.transactiongateway.com/api");
        public static GatewayProvider VizyPay { get; } = new GatewayProvider("https://vizypay.transactiongateway.com/api");

        public GatewayProvider(string postUrl)
        {
            PostUrl = postUrl;
        }
    }
}
