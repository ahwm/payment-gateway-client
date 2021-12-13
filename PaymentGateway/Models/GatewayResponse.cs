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
        public int Response { get; }
        public string ResponseText { get; }
        public ReadOnlyDictionary<string, string> Data { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        public GatewayResponse(Dictionary<string, string> values)
        {
            Response = Convert.ToInt32(values["response"]);
            ResponseText = values["responseText"];
            Data = new ReadOnlyDictionary<string, string>(values);
        }
    }
}
