using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway
{
    public partial class GatewayClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object Sale()
        {
            return MakeRequest(new object());
        }
    }
}
