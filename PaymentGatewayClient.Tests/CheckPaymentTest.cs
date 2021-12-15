using Xunit;
using PaymentGateway;
using Shouldly;
using PaymentGateway.Models;

namespace PaymentGatewayClient.Tests
{
    public class CheckPaymentTest
    {
        [Fact]
        public void SaleApprovalTest()
        {
            var securityKey = "6457Thfj624V5r7WUwc5v6a68Zsd6YEm";
            var client = new GatewayClient(securityKey);
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

            var expectedResponse = 2;
            var result = client.Sale(sale);

            result.Response.ShouldBe(expectedResponse);
        }
    }
}
