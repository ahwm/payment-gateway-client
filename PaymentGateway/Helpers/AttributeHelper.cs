using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PaymentGateway.Attributes;

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

        static bool IsList(TypeInfo type)
        {
            return type.IsGenericType && (type.GetGenericTypeDefinition() == typeof(List<>)) && type.GenericTypeArguments.FirstOrDefault() == typeof(string);
        }

        static string ConvertFromList<T>(object obj)
        {
            T list = (T)obj;

            //string arr = "";
            //foreach (object i in list)
            //    arr += $"{(arr.Length > 0 ? "," : "")}{i}";

            return String.Join(",", list);
        }
    }
}
