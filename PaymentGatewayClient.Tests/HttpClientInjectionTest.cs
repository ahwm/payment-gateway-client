using PaymentGateway;
using PaymentGateway.Models;
using Shouldly;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

namespace PaymentGatewayClient.Tests
{
#if !NET462
    /// <summary>
    /// Tests verifying that an injected <see cref="HttpClient"/> is used correctly
    /// (netstandard2.0 target only — net462 continues to use the internal HttpClient pattern)
    /// </summary>
    public class HttpClientInjectionTest
    {
        private readonly WireMockServer _wireMockServer;
        private readonly string _url;
        private readonly HttpClient _httpClient;

        public HttpClientInjectionTest()
        {
            _wireMockServer = WireMockServer.Start();
            _url = _wireMockServer.Urls.First();
            _httpClient = new HttpClient();
        }

        [Fact]
        public async Task SaleApprovalWithInjectedHttpClientTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=1&responsetext=Approved"));

            var client = new GatewayClient("6457Thfj624V5r7WUwc5v6a68Zsd6YEm", _url, _httpClient);
            var sale = new Sale
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

            var result = await client.SaleAsync(sale);

            result.Response.ShouldBe(GatewayResponseCode.Approved);
        }

        [Fact]
        public async Task SaleDeclineWithInjectedHttpClientTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=2&responsetext=Declined"));

            var client = new GatewayClient("6457Thfj624V5r7WUwc5v6a68Zsd6YEm", _url, _httpClient);
            var sale = new Sale
            {
                CardNumber = "4111111111111111",
                CardExpiration = "0323",
                CVV = "999",
                Amount = "0.50",
                FirstName = "John",
                LastName = "Smith",
                Address1 = "1234 Main St.",
                City = "Chicago",
                State = "IL",
                Zip = "60193",
                Payment = "creditcard"
            };

            var result = await client.SaleAsync(sale);

            result.Response.ShouldBe(GatewayResponseCode.Declined);
        }

        [Fact]
        public async Task SaleApprovalWithProviderAndInjectedHttpClientTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=1&responsetext=Approved"));

            var provider = new GatewayProvider(_url);
            var client = new GatewayClient("6457Thfj624V5r7WUwc5v6a68Zsd6YEm", provider, _httpClient);
            var sale = new Sale
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

            var result = await client.SaleAsync(sale);

            result.Response.ShouldBe(GatewayResponseCode.Approved);
        }
    }
#endif
}
