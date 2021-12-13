using System;
using System.Collections.Generic;
using System.Text;
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
        public GatewayResponse Sale(Sale request)
        {
            var data = new GatewayResponse(MakeRequest(request));
            if (data.Response != 1)
                throw new GatewayException($"Gateway error on {nameof(Sale)}: {data.ResponseText}");

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse Authorize(Authorize request)
        {
            var data = new GatewayResponse(MakeRequest(request));
            if (data.Response != 1)
                throw new GatewayException($"Gateway error on {nameof(Authorize)}: {data.ResponseText}");

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse Credit(Credit request)
        {
            var data = new GatewayResponse(MakeRequest(request));
            if (data.Response != 1)
                throw new GatewayException($"Gateway error on {nameof(Credit)}: {data.ResponseText}");

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse Validate(Validate request)
        {
            var data = new GatewayResponse(MakeRequest(request));
            if (data.Response != 1)
                throw new GatewayException($"Gateway error on {nameof(Validate)}: {data.ResponseText}");

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GatewayResponse Offline(Offline request)
        {
            var data = new GatewayResponse(MakeRequest(request));
            if (data.Response != 1)
                throw new GatewayException($"Gateway error on {nameof(Offline)}: {data.ResponseText}");

            return data;
        }
    }
}
