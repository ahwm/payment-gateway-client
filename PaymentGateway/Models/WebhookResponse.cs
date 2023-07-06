using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PaymentGateway.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Action
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ip_address")]
        public string IPAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("api_method")]
        public string ApiMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("response_text")]
        public string ResponseText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("processor_response_text")]
        public string ProcessorResponseText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tap_to_mobile")]
        public bool TapToMobile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("processor_response_code")]
        public string ProcessorResponseCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("device_license_number")]
        public string DeviceLicenseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("device_nickname")]
        public string DeviceNickname { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Address
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cell_phone")]
        public string CellPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fax")]
        public string Fax { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Card
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cc_number")]
        public string CCNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cc_exp")]
        public string CCExp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cavv")]
        public string CAVV { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cavv_result")]
        public string CAVVResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("xid")]
        public string XID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("eci")]
        public string ECI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("avs_response")]
        public string AVSResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("csc_response")]
        public string CSCResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cardholder_auth")]
        public string CardholderAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cc_start_date")]
        public string CCStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cc_issue_number")]
        public string CCIssueNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("card_balance")]
        public string CardBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("card_available_balance")]
        public string CardAvailableBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entry_mode")]
        public string EntryMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cc_bin")]
        public string CCBin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cc_type")]
        public string CCType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("feature_token")]
        public string FeatureToken { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Check
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("check_account")]
        public string CheckAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("check_aba")]
        public string CheckABA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("check_name")]
        public string CheckName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("sec_code")]
        public string SECCode { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Event
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("merchant")]
        public Merchant Merchant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("features")]
        public Features Features { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("transaction_type")]
        public string TransactionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("processor_id")]
        public string ProcessorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ponumber")]
        public string PONumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("order_description")]
        public string OrderDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customerid")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("customertaxid")]
        public string CustomerTaxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("website")]
        public string Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("shipping")]
        public string Shipping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tax")]
        public string Tax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("surcharge")]
        public string Surcharge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("sec_code")]
        public string CashDiscount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tip")]
        public string Tip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("requested_amount")]
        public string RequestedAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("shipping_date")]
        public string ShippingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("partial_payment_id")]
        public string PartialPaymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("partial_payment_balance")]
        public string PartialPaymentBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("platform_id")]
        public string PlatformId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("social_security_number")]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("drivers_license_number")]
        public string DriversLicenseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("drivers_license_state")]
        public string DriversLicenseState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("drivers_license_dob")]
        public string DriversLicenseDOB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("duty_amount")]
        public string DutyAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("national_tax_amount")]
        public string NationalTaxAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("summary_commodity_code")]
        public string SummaryCommodityCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("alternate_tax_amount")]
        public string AlternateTaxAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vat_tax_amount")]
        public string VatTaxAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vat_tax_rate")]
        public string VatTaxRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("billing_address")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("shipping_address")]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("check")]
        public Check Check { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("card")]
        public Card Card { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("merchant_defined_fields")]
        public Dictionary<string, object> MerchantDefinedFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("action")]
        public Action Action { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Features
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("is_test_mode")]
        public bool IsTestMode { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Merchant
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class WebhookData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("event_body")]
        public Event EventBody { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class WebhookResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public WebhookData Data;

        /// <summary>
        /// 
        /// </summary>
        public bool IsValid;

        /// <summary>
        /// Single-use nonce. The application should validate one-time use to prevent replay attacks.
        /// </summary>
        public string Nonce { get; set; }
    }
}
