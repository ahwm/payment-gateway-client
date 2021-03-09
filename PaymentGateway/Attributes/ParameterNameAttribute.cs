using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    sealed internal class ParameterNameAttribute : Attribute
    {
        public readonly string ParameterName;

        public ParameterNameAttribute(string name)
        {
            ParameterName = name;
        }
    }
}
