using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    public partial class GatewayClient
    {
        public object Sale()
        {
            return MakeRequest(new object());
        }
    }
}
