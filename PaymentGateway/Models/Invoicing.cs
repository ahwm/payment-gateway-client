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
        public string Shipping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PONumber { get; set; }

        /// <summary>
        /// Cardholder's first name.
        /// </summary>
        [ParameterName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Cardholder's last name.
        /// </summary>
        [ParameterName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Card billing state. Format: CC
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Card billing country as shown in ISO 3166. Format: CC
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_first_name")]
        public string ShippingFirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_last_name")]
        public string ShippingLastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_company")]
        public string ShippingCompany { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_address1")]
        public string ShippingAddress1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_address2")]
        public string ShippingAddress2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_city")]
        public string ShippigCity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_state")]
        public string ShippingState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_zip")]
        public string ShippingZip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_country")]
        public string ShippingCountry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("shipping_email")]
        public string ShippingEmail { get; set; }

        /// <summary>
        /// You can pass custom information in up to 20 fields.
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
    /// All variables (besides currency) on an invoice may be updated. Updating an invoice will not result in a new invoice being sent to the customer. To send the invoice after updating an invoice, use the send_invoice request after making changes.
    /// </summary>
    public class UpdateInvoice : CreateInvoice
    {
        [ParameterName("invoicing")]
        internal static new string Type => "update_invoice";

        /// <summary>
        /// The invoice ID to be updated.
        /// </summary>
        [ParameterName("invoice_id")]
        public string InvoiceId { get; set; }
    }

    /// <summary>
    /// The invoice will be sent to the billing email address assigned to the invoice.
    /// </summary>
    public class SendInvoice
    {
        [ParameterName("invoicing")]
        internal static string Type => "send_invoice";

        /// <summary>
        /// The invoice ID to be updated.
        /// </summary>
        [ParameterName("invoice_id")]
        public string InvoiceId { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class CloseInvoice
    {
        [ParameterName("invoicing")]
        internal static string Type => "close_invoice";

        /// <summary>
        /// The invoice ID to be updated.
        /// </summary>
        [ParameterName("invoice_id")]
        public string InvoiceId { get; set; }
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

        /// <summary>
        /// Unit cost of item purchased, may contain up to 4 decimal places.
        /// </summary>
        [ParameterName("item_unit_cost_#")]
        public string ItemUnitCost { get; set; }

        /// <summary>
        /// <para>Quantity of the item(s) being purchased.</para>
        /// <para>Default: '1'</para>
        /// </summary>
        [ParameterName("item_quantity_#")]
        public string ItemQuantity { get; set; }

        /// <summary>
        /// Purchase amount associated with the item. Defaults to: 'item_unit_cost_#' x 'item_quantity_#' rounded to the nearest penny.
        /// </summary>
        [ParameterName("item_total_amount_#")]
        public string ItemTotalAmount { get; set; }

        /// <summary>
        /// <para>Amount of sales tax on specific item. Amount should not be included in 'total_amount_#'.</para>
        /// <para>Default: '0.00'</para>
        /// <para>Format: x.xx</para>
        /// </summary>
        [ParameterName("item_tax_amount_#")]
        public string ItemTaxAmount { get; set; }

        /// <summary>
        /// Percentage representing the value-added tax applied.
        /// </summary>
        [ParameterName("item_tax_rate_#")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// Discount amount which can have been applied by the merchant on the sale of the specific item. Amount should not be included in 'total_amount_#'.
        /// </summary>
        [ParameterName("item_discount_amount_#")]
        public string ItemDiscountAmount { get; set; }

        /// <summary>
        /// Discount rate for the line item. 1% = 1.00.
        /// </summary>
        [ParameterName("item_discount_rate_#")]
        public string ItemDiscountRate { get; set; }

        /// <summary>
        /// Type of value-added taxes that are being used.
        /// </summary>
        [ParameterName("item_tax_type_#")]
        public string ItemTaxType { get; set; }

        /// <summary>
        /// Tax identification number of the merchant that reported the alternate tax amount.
        /// </summary>
        [ParameterName("item_alternate_tax_id_#")]
        public string ItemAlternateTaxId { get; set; }
    }
}
