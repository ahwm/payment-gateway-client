using System;
namespace PaymentGateway
{
    public class GatewayException : Exception
    {
        public GatewayException() : base()
        { }
        public GatewayException(string msg) : base(msg)
        { }
        public GatewayException(string msg, Exception innerException) : base(msg, innerException)
        { }
    }
}
