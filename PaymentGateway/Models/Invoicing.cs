using System;
using System.Collections.Generic;
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

        /// <summary>
        /// <para>Total amount to be invoiced. Must be greater than 0.00. <i>Required</i>.</para>
        /// <para>Format: x.xx</para>
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// <para>Billing email address. <i>Required</i>.</para>
        /// <para>An invoice will be sent to this address when it is created.</para>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// <para>When the invoice should be paid. One of 'upon_receipt' (default) or integers from 0-999</para>
        /// </summary>
        [ParameterName("payment_terms")]
        public string PaymentTerms { get; set; }

        /// <summary>
        /// <para>What payment methods a customer may use when paying invoice.</para>
        /// <para>Defaults to all available payment methods available in your merchant account</para>
        /// <para>Values: 'cc', 'ck', and 'cs'. Multiple payment types can be selected by comma-separating values.</para>
        /// </summary>
        [ParameterName("payment_methods_allowed")]
        public string PaymentMethodsAllowed { get; set; }

        /// <summary>
        /// <para>If using Multiple MIDs, route to this processor (processor_id is obtained under Settings → Transaction Routing in the Control Panel).</para>
        /// <para>If allowing multiple payment types, one processor_id can be selected per payment type by submitting comma-separated values.</para>
        /// </summary>
        [ParameterName("processor_id")]
        public string ProcessorId { get; set; }

        /// <summary>
        /// <para>The transaction currency. Format: ISO 4217</para>
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// <para>Order Description</para>
        /// </summary>
        [ParameterName("order_description")]
        public string OrderDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("customer_tax_id")]
        public string CustomerTaxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Tax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringListParameter("merchant_defined_field_#")]
        public List<string> MerchantDefinedFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ObjectListParameter]
        public List<InvoiceProduct> Products { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class InvoiceProduct
    {
        /// <summary>
        /// <para>Merchant defined description code of the item being purchased.</para>
        /// </summary>
        [ParameterName("item_product_code_#")]
        public string ItemProductCode { get; set; }

        /// <summary>
        /// <para>Description of the item(s) being supplied.</para>
        /// </summary>
        [ParameterName("item_description_#")]
        public string ItemDescription { get; set; }

        /// <summary>
        /// <para>International description code of the individual good or service being supplied. The acquirer or processor will provide a list of current codes.</para>
        /// </summary>
        [ParameterName("item_commodity_code_#")]
        public string ItemCommodityCode { get; set; }

        /// <summary>
        /// <para>Code for units of measurement as used in international trade. Default: 'EACH'</para>
        /// </summary>
        [ParameterName("item_unit_of_measure_#")]
        public string ItemUnitOfMeasure { get; set; }


    }
}
