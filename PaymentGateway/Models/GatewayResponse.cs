using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;

namespace PaymentGateway.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class GatewayResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public int Response { get; }

        /// <summary>
        /// 
        /// </summary>
        public string ResponseText { get; }

        /// <summary>
        /// 
        /// </summary>
        public ReadOnlyDictionary<string, string> Data { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        public GatewayResponse(Dictionary<string, string> values)
        {
            Response = (GatewayResponseCode)Convert.ToInt32(values["response"]);
            ResponseText = values["responsetext"];
            Data = new ReadOnlyDictionary<string, string>(values);
        }
    }
}
