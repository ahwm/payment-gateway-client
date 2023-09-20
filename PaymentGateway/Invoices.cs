using PaymentGateway.Models;
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
        public async Task<GatewayResponse> CreateInvoiceAsync(CreateInvoice request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> UpdateInvoiceAsync(UpdateInvoice request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> SendInvoiceAsync(SendInvoice request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> CloseInvoiceAsync(CloseInvoice request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }
    }
}
