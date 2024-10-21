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
        public async Task<GatewayResponse> AddPlanAsync(AddRecurringPlan request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// <para>Edit an existing recurring plan.</para>
        /// <para><em>Be careful when editing an existing plan, as all customers signed up for this plan will have their billing changed based on your edits.</em></para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> EditPlanAsync(EditRecurringPlan request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> AddSubscriptionAsync(AddSubscription request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> UpdateSubscriptionAsync(UpdateSubscription request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GatewayResponse> DeleteSubscriptionAsync(DeleteSubscription request)
        {
            var data = new GatewayResponse(await MakeRequest(request));

            return data;
        }
    }
}
