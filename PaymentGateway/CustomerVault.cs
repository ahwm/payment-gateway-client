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
        public async Task<GatewayResponse> AddCustomerAsync(AddCustomer request)
        {
            var data = new GatewayResponse(await MakeRequest(request).ConfigureAwait(false));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> UpdateCustomerAsync(UpdateCustomer request)
        {
            var data = new GatewayResponse(await MakeRequest(request).ConfigureAwait(false));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> DeleteCustomerAsync(DeleteCustomer request)
        {
            var data = new GatewayResponse(await MakeRequest(request).ConfigureAwait(false));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> CustomerSaleAsync(CustomerSale request)
        {
            var data = new GatewayResponse(await MakeRequest(request).ConfigureAwait(false));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> CustomerAuthAsync(CustomerAuth request)
        {
            var data = new GatewayResponse(await MakeRequest(request).ConfigureAwait(false));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> CustomerCreditAsync(CustomerCredit request)
        {
            var data = new GatewayResponse(await MakeRequest(request).ConfigureAwait(false));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> CustomerOfflineAsync(CustomerOffline request)
        {
            var data = new GatewayResponse(await MakeRequest(request).ConfigureAwait(false));

            return data;
        }
    }
}
