using PaymentGateway;
using PaymentGateway.Models;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace PaymentGatewayClient.Tests
{
    public class CCPaymentTest
    {
        [Fact]
        public async Task SaleApprovalTest()
        {
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
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
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
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
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
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
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
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
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
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
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
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
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
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

        //[Fact]
        //public void OfflineApprovalTest()
        //{
        //    var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
        //    var client = new GatewayClient(securityKey);
        //    Authorize auth = new Authorize
        //    {
        //        CardNumber = "4111111111111111",
        //        CardExpiration = "0323",
        //        CVV = "999",
        //        Amount = "1.00",
        //        FirstName = "John",
        //        LastName = "Smith",
        //        Address1 = "1234 Main St.",
        //        City = "Chicago",
        //        State = "IL",
        //        Zip = "60193",
        //        Payment = "creditcard",
        //    };
        //    var authResult = client.Authorize(auth);
        //    Offline sale = new Offline
        //    {
        //        CardNumber = "4111111111111111",
        //        CardExpiration = "0323",
        //        CVV = "999",
        //        Amount = "1.00",
        //        FirstName = "John",
        //        LastName = "Smith",
        //        Address1 = "1234 Main St.",
        //        City = "Chicago",
        //        State = "IL",
        //        Zip = "60193",
        //        Payment = "creditcard",
        //        AuthorizationCode = authResult.Data["authorization_code"]
        //    };

        //    var expectedResponse = GatewayResponseCode.Approved;
        //    var result = client.Offline(sale);

        //    result.Response.ShouldBe(expectedResponse);
        //}

        [Fact]
        public async Task OfflineDeclineTest()
        {
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
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
