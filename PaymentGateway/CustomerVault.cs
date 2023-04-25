using PaymentGateway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway
{
    public partial class GatewayClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse AddCustomer(AddCustomer request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse UpdateCustomer(UpdateCustomer request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse DeleteCustomer(DeleteCustomer request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse CustomerSale(CustomerSale request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse CustomerAuth(CustomerAuth request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse CustomerCredit(CustomerCredit request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse CustomerOffline(CustomerOffline request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }
    }
}
