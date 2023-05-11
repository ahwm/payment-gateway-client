using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
        public string Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ip_address")]
        public string IPAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("api_method")]
        public string ApiMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        public string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cell_phone")]
        public string CellPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        public string CAVV { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("cavv_result")]
        public string CAVVResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string XID { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        public Merchant merchant { get; set; }
        public Features features { get; set; }
        public string transaction_id { get; set; }
        public string transaction_type { get; set; }
        public string condition { get; set; }
        public string processor_id { get; set; }
        public string ponumber { get; set; }
        public string order_description { get; set; }
        public string order_id { get; set; }
        public string customerid { get; set; }
        public string customertaxid { get; set; }
        public string website { get; set; }
        public string shipping { get; set; }
        public string currency { get; set; }
        public string tax { get; set; }
        public string surcharge { get; set; }
        public string cash_discount { get; set; }
        public string tip { get; set; }
        public string requested_amount { get; set; }
        public string shipping_carrier { get; set; }
        public string tracking_number { get; set; }
        public string shipping_date { get; set; }
        public string partial_payment_id { get; set; }
        public string partial_payment_balance { get; set; }
        public string platform_id { get; set; }
        public string authorization_code { get; set; }
        public string social_security_number { get; set; }
        public string drivers_license_number { get; set; }
        public string drivers_license_state { get; set; }
        public string drivers_license_dob { get; set; }
        public string duty_amount { get; set; }
        public string discount_amount { get; set; }
        public string national_tax_amount { get; set; }
        public string summary_commodity_code { get; set; }
        public string alternate_tax_amount { get; set; }
        public string vat_tax_amount { get; set; }
        public string vat_tax_rate { get; set; }
        public Address billing_address { get; set; }
        public Address shipping_address { get; set; }
        public Check check { get; set; }
        public Card card { get; set; }
        public Dictionary<string, object> merchant_defined_fields { get; set; }
        public Action action { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Features
    {
        public bool is_test_mode { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Merchant
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class WebhookResponse
    {
        public string event_id { get; set; }
        public string event_type { get; set; }
        public Event event_body { get; set; }
    }
}
