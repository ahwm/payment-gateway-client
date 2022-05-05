using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace PaymentGateway.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class GatewayEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public ReadOnlyDictionary<string, string> Results => new ReadOnlyDictionary<string, string>(_results);
        private readonly Dictionary<string, string> _results;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_values"></param>
        public GatewayEventArgs(NameValueCollection _values)
        {
            _results = new Dictionary<string, string>();
            foreach (var k in _values.AllKeys)
            {
                if (!Log.NoInclude.Contains(k))
                    _results.Add(k, _values[k]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_values"></param>
        public GatewayEventArgs(Dictionary<string, string> _values)
        {
            _results = new Dictionary<string, string>();
            foreach (var k in _values.Keys)
            {
                if (!Log.NoInclude.Contains(k))
                    _results.Add(k, _values[k]);
            }
        }
    }
}
