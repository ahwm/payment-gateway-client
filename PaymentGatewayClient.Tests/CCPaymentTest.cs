using PaymentGateway;
using PaymentGateway.Models;
using Shouldly;
using Xunit;

namespace PaymentGatewayClient.Tests
{
    public class CCPaymentTest
    {
        [Fact]
        public void SaleApprovalTest()
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

            var expectedResponse = 1;
            var result = client.Sale(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public void SaleDeclineTest()
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

            var expectedResponse = 2;
            var result = client.Sale(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public void AuthorizeApprovalTest()
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

            var expectedResponse = 1;
            var result = client.Authorize(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public void AuthorizeDeclineTest()
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

            var expectedResponse = 2;
            var result = client.Authorize(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public void CreditApprovalTest()
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

            var expectedResponse = 1;
            var result = client.Credit(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public void CreditDeclineTest()
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

            var expectedResponse = 3;
            var result = client.Credit(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public void ValidateApprovalTest()
        {
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
            Validate sale = new Validate
            {
                CardNumber = "4111111111111111",
                CardExpiration = "0321",
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

            var expectedResponse = 1;
            var result = client.Validate(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public void OfflineApprovalTest()
        {
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
            Offline sale = new Offline
            {
                CardNumber = "4111111111111111",
                CardExpiration = "0321",
                CVV = "999",
                Amount = "1.00",
                FirstName = "John",
                LastName = "Smith",
                Address1 = "1234 Main St.",
                City = "Chicago",
                State = "IL",
                Zip = "60193",
                Payment = "creditcard",
                AuthorizationCode = "123456"
            };

            var expectedResponse = 1;
            var result = client.Offline(sale);

            result.Response.ShouldBe(expectedResponse);
        }

        [Fact]
        public void OfflineDeclineTest()
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

            var expectedResponse = 3;
            var result = client.Offline(sale);

            result.Response.ShouldBe(expectedResponse);
        }
    }
}
