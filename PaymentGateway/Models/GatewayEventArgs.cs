using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace PaymentGateway.Models
{
    public class GatewayEventArgs : EventArgs
    {
        public ReadOnlyDictionary<string, string> Results { get { return new ReadOnlyDictionary<string, string>(_results); } }
        private Dictionary<string, string> _results;

        public GatewayEventArgs(NameValueCollection _values)
        {
            _results = new Dictionary<string, string>();
            foreach (var k in _values.AllKeys)
            {
                if (!Log.NoInclude.Contains(k))
                    _results.Add(k, _values[k]);
            }
        }
    }
}
