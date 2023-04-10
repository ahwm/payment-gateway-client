using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    sealed internal class ObjectListParameterAttribute : Attribute
    {
        public ObjectListParameterAttribute()
        { }
    }
}
