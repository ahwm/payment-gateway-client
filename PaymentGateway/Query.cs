using PaymentGateway.Models;
using PaymentGateway.Query.Models;
using System.Threading.Tasks;

namespace PaymentGateway
{
    public partial class GatewayClient
    {
        /// <summary>
        /// Query transaction and reporting data from the gateway.
        /// </summary>
        /// <param name="request">The query parameters to filter results.</param>
        /// <returns>A <see cref="QueryResponse"/> containing matching transactions or subscriptions.</returns>
        public async Task<QueryResponse> QueryAsync(QueryRequest request)
        {
            return await MakeQueryRequest(request).ConfigureAwait(false);
        }
    }
}
