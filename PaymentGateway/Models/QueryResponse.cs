using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PaymentGateway.Query.Models
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(NmResponse));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (NmResponse)serializer.Deserialize(reader);
    // }

    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(ElementName = "product")]
    public class Product
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "quantity")]
        public double Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "amount")]
        public double Amount { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(ElementName = "action")]
    public class Action
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "amount")]
        public double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "date")]
        public double Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "success")]
        public int Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "api_method")]
        public object ApiMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "response_text")]
        public string ResponseText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "batch_id")]
        public int BatchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "processor_batch_id")]
        public object ProcessorBatchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "response_code")]
        public int ResponseCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "processor_response_text")]
        public string ProcessorResponseText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "processor_response_code")]
        public int ProcessorResponseCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "requested_amount")]
        public double RequestedAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "device_license_number")]
        public object DeviceLicenseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "device_nickname")]
        public object DeviceNickname { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(ElementName = "transaction")]
    public class Transaction
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "transaction_id")]
        public double TransactionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "partial_payment_id")]
        public object PartialPaymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "partial_payment_balance")]
        public object PartialPaymentBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "platform_id")]
        public object PlatformId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "transaction_type")]
        public string TransactionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "authorization_code")]
        public int AuthorizationCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "ponumber")]
        public object Ponumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "order_description")]
        public object OrderDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "company")]
        public object Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "city")]
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "state")]
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "postal_code")]
        public int PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "phone")]
        public int Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "fax")]
        public object Fax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cell_phone")]
        public object CellPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "customertaxid")]
        public object Customertaxid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "customerid")]
        public object Customerid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "website")]
        public object Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_first_name")]
        public object ShippingFirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_last_name")]
        public object ShippingLastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_address_1")]
        public object ShippingAddress1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_address_2")]
        public object ShippingAddress2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_company")]
        public object ShippingCompany { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_city")]
        public object ShippingCity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_state")]
        public object ShippingState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_postal_code")]
        public object ShippingPostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_country")]
        public object ShippingCountry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_email")]
        public object ShippingEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_carrier")]
        public object ShippingCarrier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "tracking_number")]
        public object TrackingNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_date")]
        public object ShippingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping")]
        public double Shipping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "shipping_phone")]
        public object ShippingPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cc_number")]
        public string CcNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cc_hash")]
        public string CcHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cc_exp")]
        public int CcExp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cavv")]
        public object Cavv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cavv_result")]
        public object CavvResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "xid")]
        public object Xid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "eci")]
        public object Eci { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "directory_server_id")]
        public object DirectoryServerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "three_ds_version")]
        public object ThreeDsVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "avs_response")]
        public string AvsResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "csc_response")]
        public string CscResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cardholder_auth")]
        public object CardholderAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cc_start_date")]
        public object CcStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cc_issue_number")]
        public object CcIssueNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "check_account")]
        public object CheckAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "check_hash")]
        public object CheckHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "check_aba")]
        public object CheckAba { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "check_name")]
        public object CheckName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "account_holder_type")]
        public object AccountHolderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "account_type")]
        public object AccountType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "sec_code")]
        public object SecCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "drivers_license_number")]
        public object DriversLicenseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "drivers_license_state")]
        public object DriversLicenseState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "drivers_license_dob")]
        public object DriversLicenseDob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "social_security_number")]
        public object SocialSecurityNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "processor_id")]
        public string ProcessorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "tax")]
        public double Tax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "surcharge")]
        public object Surcharge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cash_discount")]
        public object CashDiscount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "tip")]
        public object Tip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "card_balance")]
        public object CardBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "card_available_balance")]
        public object CardAvailableBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "entry_mode")]
        public string EntryMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cc_bin")]
        public int CcBin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "cc_type")]
        public string CcType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "signature_image")]
        public string SignatureImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "product")]
        public Product Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "action")]
        public List<Action> Action { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(ElementName = "nm_response")]
    public class NmResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "transaction")]
        public Transaction Transaction { get; set; }
    }


}
