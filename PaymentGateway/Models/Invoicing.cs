using System;
using PaymentGateway.Attributes;

namespace PaymentGateway.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateInvoice
    {
        [ParameterName("invoicing")]
        internal static string Type => "add_invoice";


    }
}
