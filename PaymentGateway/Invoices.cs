using PaymentGateway.Models;
namespace PaymentGateway
{
    public partial class GatewayClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse CreateInvoice(CreateInvoice request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse UpdateInvoice(UpdateInvoice request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse SendInvoice(SendInvoice request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse CloseInvoice(CloseInvoice request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }
    }
}
