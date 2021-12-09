using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    /// <summary>
    /// 
    /// </summary>
    public class GatewayProvider
    {
        internal string PostUrl { get; }

        /// <summary>
        /// 0 Merchant. See <a href="https://0merchant.transactiongateway.com/merchants/resources/integration/integration_portal.php">https://0merchant.transactiongateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider ZeroMerchant { get; } = new GatewayProvider("https://0merchant.transactiongateway.com/api");

        /// <summary>
        /// Advanced Merchant Group. See <a href="https://secure.advancedmerchantgroupgateway.com/merchants/resources/integration/integration_portal.php">https://secure.advancedmerchantgroupgateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider AdvancedMerchantGroup { get; } = new GatewayProvider("https://secure.advancedmerchantgroupgateway.com/api");

        /// <summary>
        /// Aliant Payments. See <a href="https://secure.apsmerchantgateway.com/merchants/resources/integration/integration_portal.php">https://secure.apsmerchantgateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider AliantPayments { get; } = new GatewayProvider("https://secure.apsmerchantgateway.com/api");

        /// <summary>
        /// Bottom Line Payments. See <a href="https://secure.bottomlinegateway.com/merchants/resources/integration/integration_portal.php">https://secure.bottomlinegateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider BottomLinePayments { get; } = new GatewayProvider("https://secure.bottomlinegateway.com/api");

        /// <summary>
        /// Canyon Pay. See <a href="https://canyonpay.transactiongateway.com/merchants/resources/integration/integration_portal.php">https:/canyonpay.transactiongateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider CanyonPay { get; } = new GatewayProvider("https://canyonpay.transactiongateway.com/api");

        /// <summary>
        /// CyoGate. See <a href="https://secure.cyogate.net/merchants/resources/integration/integration_portal.php">https://secure.cyogate.net/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider CyoGate { get; } = new GatewayProvider("https://secure.cyogate.net/api");

        /// <summary>
        /// Durango Merchant Services. See <a href="https://secure.durango-direct.com/merchants/resources/integration/integration_portal.php">https://secure.durango-direct.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider DurangoMerchantServices { get; } = new GatewayProvider("https://secure.durango-direct.com/api");

        /// <summary>
        /// Easy Pay Direct. See <a href="https://secure.easypaydirectgateway.com//merchants/resources/integration/integration_portal.php">https://secure.easypaydirectgateway.com//merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider EasyPayDirect { get; } = new GatewayProvider("https://secure.easypaydirectgateway.com/api");

        /// <summary>
        /// Electronic Processing of North America (EPNA). See <a href="https://epna.transactiongateway.com/merchants/resources/integration/integration_portal.php">https://epna.transactiongateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider EPNA { get; } = new GatewayProvider("https://epna.transactiongateway.com/api");

        /// <summary>
        /// Inspire Commerce (.pay / dot pay). See <a href="https://secure.inspiregateway.net/merchants/resources/integration/integration_portal.php">https://secure.inspiregateway.net/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider InspireCommerceDotPay { get; } = new GatewayProvider("https://secure.inspiregateway.net/api");

        /// <summary>
        /// Merchant Guy. See <a href="https://secure.merchantguygateway.com/merchants/resources/integration/integration_portal.php">https://secure.merchantguygateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider MerchantGuy { get; } = new GatewayProvider("https://secure.merchantguygateway.com/api");

        /// <summary>
        /// Merchant One. See <a href="https://secure.merchantonegateway.com/merchants/resources/integration/integration_portal.php">https://secure.merchantonegateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider MerchantOne { get; } = new GatewayProvider("https://secure.merchantonegateway.com/api");

        /// <summary>
        /// MSG Payment Systems. See <a href="https://msgpay.transactiongateway.com/merchants/resources/integration/integration_portal.php">https://msgpay.transactiongateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider MSGPay { get; } = new GatewayProvider("https://msgpay.transactiongateway.com/api");

        /// <summary>
        /// National Processing. See <a href="https://secure.nationalprocessinggateway.com/merchants/resources/integration/integration_portal.php">https://secure.nationalprocessinggateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider NationalProcessing { get; } = new GatewayProvider("https://secure.nationalprocessinggateway.com/api");

        /// <summary>
        /// Network Merchants (NMI). See <a href="https://secure.networkmerchants.com/merchants/resources/integration/integration_portal.php">https://secure.networkmerchants.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider NMI { get; } = new GatewayProvider("https://secure.networkmerchants.com/api");

        /// <summary>
        /// PayKings. See <a href="https://paykings.transactiongateway.com/merchants/resources/integration/integration_portal.php">https://paykings.transactiongateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider PayKings { get; } = new GatewayProvider("https://paykings.transactiongateway.com/api");

        /// <summary>
        /// Payscape. See <a href="https://secure.payscapegateway.com/merchants/resources/integration/integration_portal.php">https://secure.payscapegateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider Payscape { get; } = new GatewayProvider("https://secure.payscapegateway.com/api");

        /// <summary>
        /// PlanetAuthorize. See <a href="https://secure.planetauthorizegateway.com/merchants/resources/integration/integration_portal.php">https://secure.planetauthorizegateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider PlanetAuthorize { get; } = new GatewayProvider("https://secure.planetauthorizegateway.com/api");

        /// <summary>
        /// RedFynn Technologies. See <a href="https://secure.redfynngateway.com/merchants/resources/integration/integration_portal.php">https://secure.redfynngateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider RedFynn { get; } = new GatewayProvider("https://secure.redfynngateway.com/api");

        /// <summary>
        /// SecureGlobalPay. See <a href="https://secureglobalpay.transactiongateway.com/merchants/resources/integration/integration_portal.php">https://secureglobalpay.transactiongateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider SecureGlobalPay { get; } = new GatewayProvider("https://secureglobalpay.transactiongateway.com/api");

        /// <summary>
        /// SkyBank Financial. See <a href="https://secure.skybankgateway.com/merchants/resources/integration/integration_portal.php">https://secure.skybankgateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider SkyBank { get; } = new GatewayProvider("https://secure.skybankgateway.com/api");

        /// <summary>
        /// TranzCrypt. See <a href="https://secure.tranzcrypt.com/merchants/resources/integration/integration_portal.php">https://secure.tranzcrypt.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider TranzCrypt { get; } = new GatewayProvider("https://secure.tranzcrypt.com/api");

        /// <summary>
        /// Vericheck. See <a href="https://vericheck.transactiongateway.com/merchants/resources/integration/integration_portal.php">https://vericheck.transactiongateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider Vericheck { get; } = new GatewayProvider("https://vericheck.transactiongateway.com/api");

        /// <summary>
        /// VizyPay. See <a href="https://vizypay.transactiongateway.com/merchants/resources/integration/integration_portal.php">https://vizypay.transactiongateway.com/merchants/resources/integration/integration_portal.php</a>
        /// </summary>
        public static GatewayProvider VizyPay { get; } = new GatewayProvider("https://vizypay.transactiongateway.com/api");

        /// <summary>
        ///  Please file an issue at <a href="https://github.com/ahwm/payment-gateway-client">https://github.com/ahwm/payment-gateway-client</a> if using a provider not included
        /// </summary>
        /// <param name="postUrl"></param>
        public GatewayProvider(string postUrl)
        {
            PostUrl = postUrl;
        }
    }
}
