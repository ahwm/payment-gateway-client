using System;
using System.Collections;
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
                    if (property.GetCustomAttribute(typeof(ParameterNameAttribute)) is ParameterNameAttribute paramName)
                        l.Add(new KeyValuePair<string, string>(paramName.ParameterName, property.GetValue(model).ToString()));
                    else if (property.GetCustomAttribute(typeof(ObjectListParameterAttribute)) is ObjectListParameterAttribute objList)
                    {
                        int paramId = 1;
                        var @params = property.GetValue(model, null) as IList;
                        foreach (var p in @params)
                        {
                            var names = GetAttributes(p);
                            foreach (var name in names)
                                l.Add(new KeyValuePair<string, string>(name.Key.Replace("#", paramId.ToString()), name.Value));
                            paramId++;
                        }
                    }
                    else if (property.GetCustomAttribute(typeof(StringListParameterAttribute)) is StringListParameterAttribute strList)
                    {
                        int paramId = 1;
                        var @params = property.GetValue(model) as List<string>;
                        foreach (var p in @params)
                        {
                            l.Add(new KeyValuePair<string, string>(strList.ParameterName.Replace("#", paramId.ToString()), p));
                            paramId++;
                        }
                    }
                    else
                        l.Add(new KeyValuePair<string, string>(property.Name.ToLower(), property.GetValue(model).ToString()));
                }
            }

            return l;
        }
    }
}
