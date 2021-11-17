using PaymentGateway.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PaymentGateway.Helpers
{
    internal static class AttributeHelper
    {
        public static List<KeyValuePair<string, string>> GetAttributes(object model)
        {
            List<KeyValuePair<string, string>> l = new List<KeyValuePair<string, string>>();

            foreach (var property in model.GetType().GetRuntimeProperties())
            {
                if (property.GetValue(model) != null)
                {
                    if (property.GetCustomAttribute(typeof(ParameterNameAttribute)) is ParameterNameAttribute attribute)
                        l.Add(new KeyValuePair<string, string>(attribute.ParameterName, property.GetValue(model).ToString()));
                    else
                        l.Add(new KeyValuePair<string, string>(property.Name.ToLower(), property.GetValue(model).ToString()));
                }
            }

            return l;
        }
    }
}
