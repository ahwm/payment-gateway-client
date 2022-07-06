# Payment Gateway Client

[![nuget](https://img.shields.io/nuget/vpre/PaymentGatewayClient.svg)](https://www.nuget.org/packages/PaymentGatewayClient)

There are several "smaller" merchant payment gateways that all use the same API system. This client is meant to work with all of them. Below is a list of known providers that use this system.

Original documentation: <https://integratepayments.transactiongateway.com/merchants/resources/integration/integration_portal.php>

<https://www.integratepayments.com/payment-gateway/integrate-payments-query-api>

<http://status.transactiongateway.com/>

## Known Providers

* [0 Merchant](https://0merchant.transactiongateway.com/merchants/resources/integration/integration_portal.php)
* [Advanced Merchant Group](https://secure.advancedmerchantgroupgateway.com/merchants/resources/integration/integration_portal.php)
* [Aliant Payments](https://secure.apsmerchantgateway.com/merchants/resources/integration/integration_portal.php)
* [Bottom Line Payments](https://secure.bottomlinegateway.com/merchants/resources/integration/integration_portal.php)
* [CanyonPay](https://canyonpay.transactiongateway.com/merchants/resources/integration/integration_portal.php)
* [CryptoBucks](https://secure.apsmerchantgateway.com/merchants/resources/integration/integration_portal.php) (not for their crypto currency API)
* [CyoGate](https://secure.cyogate.net/merchants/resources/integration/integration_portal.php)
* [Durango Merchant Services](https://secure.durango-direct.com/merchants/resources/integration/integration_portal.php)
* [Easy Pay Direct](https://secure.easypaydirectgateway.com/gw/merchants/resources/integration/integration_portal.php)
* [Electronic Processing of North America (EPNA)](https://epna.transactiongateway.com/merchants/resources/integration/integration_portal.php)
* [Inspire Commerce (.pay / dot pay)](https://secure.inspiregateway.net/merchants/resources/integration/integration_portal.php)
* [Merchant Guy](https://vizypay.transactiongateway.com/merchants/resources/integration/integration_portal.php)
* [Merchant One](https://secure.merchantonegateway.com/merchants/resources/integration/integration_portal.php)
* [MSG Payment Systems](https://msgpay.transactiongateway.com/merchants/resources/integration/integration_portal.php)
* [National Processing](https://secure.nationalprocessinggateway.com/merchants/resources/integration/integration_portal.php)
* [Network Merchants (NMI)](https://secure.networkmerchants.com/merchants/resources/integration/integration_portal.php)
* [Payabli (Centavo)](https://centavo.transactiongateway.com/merchants/resources/integration/integration_portal.php)
* [PayKings](https://paykings.transactiongateway.com/merchants/resources/integration/integration_portal.php)
* [Payscape](https://secure.payscapegateway.com/merchants/resources/integration/integration_portal.php)
* [PlanetAuthorize](https://secure.planetauthorizegateway.com/merchants/resources/integration/integration_portal.php)
* [RedFynn Technologies](https://secure.redfynngateway.com/merchants/resources/integration/integration_portal.php)
* [SecureGlobalPay](https://secureglobalpay.transactiongateway.com/merchants/resources/integration/integration_portal.php)
* [SkyBank Financial](https://secure.skybankgateway.com/merchants/resources/integration/integration_portal.php)
* [TranzCrypt](https://secure.tranzcrypt.com/merchants/resources/integration/integration_portal.php)
* [Valued Merchant Services](https://secure.valuedmerchantgateway.com/merchants/resources/integration/integration_portal.php)
* [Vericheck](https://vericheck.transactiongateway.com/merchants/resources/integration/integration_portal.php)
* [VizyPay](https://vizypay.transactiongateway.com/merchants/resources/integration/integration_portal.php)

***Note:*** *This is not an indication of endorsement and there is no guarantee of compatibility. With the exception of NMI, these providers have not been tested. Based on current experience, it may be possible to use any of these (and new) providers using the `NMI` API endpoint though this use case has not been tested.*

If you find another gateway that uses this system, please file an issue to get this list updated.

## Usage

### Credit/Debit Cards

```csharp
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm"; // test account
            var client = new GatewayClient(securityKey, GatewayProvider.NMI);
            Sale sale = new Sale
            {
                CardNumber = "4111111111111111",
                CardExpiration = "0323",
                CVV = "999",
                Amount = "5.00",
                FirstName = "John",
                LastName = "Smith",
                Address1 = "1234 Main St.",
                City = "Chicago",
                State = "IL",
                Zip = "60193",
                Payment = "creditcard"
            };

            var result = client.Sale(sale);
```

### ACH/eCheck

```csharp
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm"; // test account
            var client = new GatewayClient(securityKey, GatewayProvider.NMI);
            Sale sale = new Sale
            {
                CheckABA = "123123123",
                CheckAccount = "123123123",
                CheckName = "John Smith",
                StandardEntryClass = "WEB",
                Amount = "5.00",
                FirstName = "John",
                LastName = "Smith",
                Address1 = "1234 Main St.",
                City = "Chicago",
                State = "IL",
                Zip = "60193",
                Payment = "check",
                AccountHolderType = "business",
                AccountType = "checking"
            };

            var result = client.Sale(sale);
```

### Response

```csharp
public class GatewayResponse {
    public readonly GatewayResponseCode Response; // Approved, Declined, Error
    public readonly string ResponseText;
    public readonly ReadOnlyDictionary<string, string> Data;
}
```
