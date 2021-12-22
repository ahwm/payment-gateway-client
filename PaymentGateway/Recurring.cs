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
        public GatewayResponse AddPlan(AddRecurringPlan request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// <para>Edit an existing recurring plan.</para>
        /// <para><em>Be careful when editing an existing plan, as all customers signed up for this plan will have their billing changed based on your edits.</em></para>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse EditPlan(EditRecurringPlan request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse AddSubscription(AddSubscription request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse UpdateSubscription(UpdateSubscription request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse DeleteSubscription(DeleteSubscription request)
        {
            var data = new GatewayResponse(MakeRequest(request));

            return data;
        }
    }
}
