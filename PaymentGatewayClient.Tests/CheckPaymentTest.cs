using Xunit;
using PaymentGateway;
using Shouldly;
using PaymentGateway.Models;
using System.Threading.Tasks;
using WireMock.Server;
using System.Linq;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;

namespace PaymentGatewayClient.Tests
{
    public class CheckPaymentTest
    {
        private readonly WireMockServer _wireMockServer;
        private readonly string _url;

        public CheckPaymentTest() 
        {
            _wireMockServer = WireMockServer.Start();
            _url = _wireMockServer.Urls.First();
        }

        [Fact]
        public async Task SaleApprovalTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=1&responsetext=Approved"));

            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey, _url);
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

            var expectedResponse = GatewayResponseCode.Approved;
            var result = await client.SaleAsync(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public async Task SaleDeclineTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=2&responsetext=Declined"));

            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey, _url);
            Sale sale = new Sale
            {
                CheckABA = "123123123",
                CheckAccount = "123123123",
                CheckName = "John Smith",
                StandardEntryClass = "WEB",
                Amount = "0.50",
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

            var expectedResponse = GatewayResponseCode.Declined;
            var result = await client.SaleAsync(sale);

            result.Response.ShouldBe(expectedResponse);
        }
    }
}
