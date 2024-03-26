using PaymentGateway;
using PaymentGateway.Models;
using Shouldly;
using System.Threading.Tasks;
using System.Linq;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

namespace PaymentGatewayClient.Tests
{
    public class CCPaymentTest
    {
        private readonly WireMockServer _wireMockServer;
        private readonly string _url;

        public CCPaymentTest()
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

            var expectedResponse = GatewayResponseCode.Declined;
            var result = await client.SaleAsync(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public async Task AuthorizeApprovalTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=1&responsetext=Approved"));

            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey, _url);
            Authorize sale = new Authorize
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

            var expectedResponse = GatewayResponseCode.Approved;
            var result = await client.AuthorizeAsync(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public async Task AuthorizeDeclineTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=2&responsetext=Declined"));

            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey, _url);
            Authorize sale = new Authorize
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

            var expectedResponse = GatewayResponseCode.Declined;
            var result = await client.AuthorizeAsync(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public async Task CreditApprovalTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=1&responsetext=Approved"));

            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey, _url);
            Credit sale = new Credit
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

            var expectedResponse = GatewayResponseCode.Approved;
            var result = await client.CreditAsync(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public async Task CreditDeclineTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=3&responsetext=Error"));

            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey, _url);
            Credit sale = new Credit
            {
                CardNumber = "4111111111111112",
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

            var expectedResponse = GatewayResponseCode.Error;
            var result = await client.CreditAsync(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public async Task ValidateApprovalTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=1&responsetext=Approved"));

            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey, _url);
            Validate sale = new Validate
            {
                CardNumber = "4111111111111111",
                CardExpiration = "0323",
                CVV = "999",
                //Amount = "1.00",
                FirstName = "John",
                LastName = "Smith",
                Address1 = "1234 Main St.",
                City = "Chicago",
                State = "IL",
                Zip = "60193",
                Payment = "creditcard"
            };

            var expectedResponse = GatewayResponseCode.Approved;
            var result = await client.ValidateAsync(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public void OfflineApprovalTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=1&responsetext=Approved&authorization_code=123456789"));

            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey, _url);
            Authorize auth = new Authorize
            {
                CardNumber = "4111111111111111",
                CardExpiration = "0323",
                CVV = "999",
                Amount = "1.00",
                FirstName = "John",
                LastName = "Smith",
                Address1 = "1234 Main St.",
                City = "Chicago",
                State = "IL",
                Zip = "60193",
                Payment = "creditcard",
            };
            var authResult = client.Authorize(auth);
            Offline sale = new Offline
            {
                CardNumber = "4111111111111111",
                CardExpiration = "0323",
                CVV = "999",
                Amount = "1.00",
                FirstName = "John",
                LastName = "Smith",
                Address1 = "1234 Main St.",
                City = "Chicago",
                State = "IL",
                Zip = "60193",
                Payment = "creditcard",
                AuthorizationCode = authResult.Data["authorization_code"]
            };

            var expectedResponse = GatewayResponseCode.Approved;
            var result = client.Offline(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public async Task OfflineDeclineTest()
        {
            _wireMockServer
                .Given(Request.Create().WithPath("/transact.php"))
                .RespondWith(Response.Create().WithStatusCode(200)
                .WithBody("response=3&responsetext=Error"));

            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey, _url);
            Offline sale = new Offline
            {
                CardNumber = "4111111111111112",
                CardExpiration = "0321",
                CVV = "999",
                Amount = "0.50",
                FirstName = "John",
                LastName = "Smith",
                Address1 = "1234 Main St.",
                City = "Chicago",
                State = "IL",
                Zip = "60193",
                Payment = "creditcard",
                AuthorizationCode = "123457"
            };

            var expectedResponse = GatewayResponseCode.Error;
            var result = await client.OfflineAsync(sale);

            result.Response.ShouldBe(expectedResponse);
        }
    }
}
