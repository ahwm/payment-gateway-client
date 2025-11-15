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
        public async Task<GatewayResponse> SaleAsync(Sale request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> AuthorizeAsync(Authorize request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> CreditAsync(Credit request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> ValidateAsync(Validate request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> OfflineAsync(Offline request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> CaptureAsync(Capture request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }
    }
}
