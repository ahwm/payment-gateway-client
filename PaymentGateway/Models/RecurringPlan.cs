using PaymentGateway.Attributes;

namespace PaymentGateway.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AddRecurringPlan
    {
        [ParameterName("recurring")]
        internal static string Type => "add_plan";

        /// <summary>
        /// <para>The number of payments before the recurring plan is complete.</para>
        /// <para>Notes: '0' for until canceled</para>
        /// </summary>
        [ParameterName("plan_payments")]
        public string PlanPayments { get; set; }

        /// <summary>
        /// <para>The plan amount to be charged each billing cycle.</para>
        /// <para>Format: x.xx</para>
        /// </summary>
        [ParameterName("plan_amount")]
        public string PlanAmount { get; set; }

        /// <summary>
        /// The display name of the plan.
        /// </summary>
        [ParameterName("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// The unique plan ID that references only this recurring plan.
        /// </summary>
        [ParameterName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// How often, in days, to charge the customer. Cannot be set with 'month_frequency' or 'day_of_month'.
        /// </summary>
        [ParameterName("day_frequency")]
        public string DayFrequency { get; set; }

        /// <summary>
        /// <para>How often, in months, to charge the customer. Cannot be set with 'day_frequency'. Must be set with 'day_of_month'.</para>
        /// <para>Values: 1 through 24</para>
        /// </summary>
        [ParameterName("month_frequency")]
        public string MonthFrequency { get; set; }

        /// <summary>
        /// <para>The day that the customer will be charged. Cannot be set with 'day_frequency'. Must be set with 'month_frequency'.</para>
        /// <para>Values: 1 through 31 - for months without 29, 30, or 31 days, the charge will be on the last day</para>
        /// </summary>
        [ParameterName("day_of_month")]
        public string DayOfMonth { get; set; }
    }

    /// <summary>
    /// <para>Edit an existing recurring plan.</para>
    /// <para><em>Be careful when editing an existing plan, as all customers signed up for this plan will have their billing changed based on your edits.</em></para>
    /// </summary>
    public class EditRecurringPlan : AddRecurringPlan
    {
        [ParameterName("recurring")]
        new internal static string Type => "edit_plan";

        /// <summary>
        /// Only relevant for editing an existing plan, the value will be the 'plan_id' that will be edited in this request.
        /// </summary>
        [ParameterName("current_plan_id")]
        public string CurrentPlanId { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class AddSubscription
    {
        [ParameterName("recurring")]
        internal static string Type => "add_subscription";

        /// <summary>
        /// <para>The plan ID of the plan that the subscription will be associated with.</para>
        /// <para>Omit to add custom subscription.</para>
        /// </summary>
        [ParameterName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The number of payments before the recurring plan is complete.</para>
        /// <para>Notes: '0' for until canceled</para>
        /// <para><em>Omit if 'PlanId' is set</em></para>
        /// </summary>
        [ParameterName("plan_payments")]
        public string PlanPayments { get; set; }

        /// <summary>
        /// <para>The plan amount to be charged each billing cycle.</para>
        /// <para>Format: x.xx</para>
        /// <para><em>Omit if 'PlanId' is set</em></para>
        /// </summary>
        [ParameterName("plan_amount")]
        public string PlanAmount { get; set; }

        /// <summary>
        /// <para>How often, in days, to charge the customer. Cannot be set with 'month_frequency' or 'day_of_month'.</para>
        /// <para><em>Omit if 'PlanId' is set</em></para>
        /// </summary>
        [ParameterName("day_frequency")]
        public string DayFrequency { get; set; }

        /// <summary>
        /// <para>How often, in months, to charge the customer. Cannot be set with 'day_frequency'. Must be set with 'day_of_month'.</para>
        /// <para>Values: 1 through 24</para>
        /// <para><em>Omit if 'PlanId' is set</em></para>
        /// </summary>
        [ParameterName("month_frequency")]
        public string MonthFrequency { get; set; }

        /// <summary>
        /// <para>The day that the customer will be charged. Cannot be set with 'day_frequency'. Must be set with 'month_frequency'.</para>
        /// <para>Values: 1 through 31 - for months without 29, 30, or 31 days, the charge will be on the last day</para>
        /// <para><em>Omit if 'PlanId' is set</em></para>
        /// </summary>
        [ParameterName("day_of_month")]
        public string DayOfMonth { get; set; }

        /// <summary>
        /// <para>The first day that the customer will be charged.</para>
        /// <para>Format: YYYYMMDD</para>
        /// </summary>
        [ParameterName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// The tokenized version of the customer's card or check information. This will be generated by Collect.js and is usable only once.
        /// </summary>
        [ParameterName("payment_token")]
        public string PaymentToken { get; set; }

        /// <summary>
        /// The encrypted token created when integration directly to the Google Pay SDK.
        /// </summary>
        [ParameterName("googlepay_payment_data")]
        public string GooglePayPaymentData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("ccnumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("ccexp")]
        public string CardExpiration { get; set; }

        /// <summary>
        /// Type of payment ("creditcard" or "check")
        /// </summary>
        public string Payment { get; set; } = "creditcard";

        /// <summary>
        /// Name on the customer's ACH account
        /// </summary>
        public string CheckName { get; set; }

        /// <summary>
        /// Customer's bank routing number
        /// </summary>
        public string CheckABA { get; set; }

        /// <summary>
        /// Customer's bank account number
        /// </summary>
        public string CheckAccount { get; set; }

        /// <summary>
        /// The type of ACH account the customer has ("business" or "personal")
        /// </summary>
        [ParameterName("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// The ACH account entity of the customer ("checking" or "savings")
        /// </summary>
        [ParameterName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// The Standard Entry Class code of the ACH transaction ("PPD", "WEB", "TEL", or "CCD")
        /// </summary>
        [ParameterName("sec_code")]
        public string StandardEntryClass { get; set; }

        /// <summary>
        /// The transaction currency. Format: ISO 4217 (USD, CAD, etc)
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address1 { get; set; }

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
        public string Zip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("order_description")]
        public string OrderDescription { get; set; }

        /// <summary>
        /// If using Multiple MIDs, route to this processor (processor_id is obtained under Settings → Transaction Routing in the Control Panel).
        /// </summary>
        [ParameterName("processor_id")]
        public string ProcessorId { get; set; }

        /// <summary>
        /// Cardholder's purchase order number.
        /// </summary>
        public string PONumber { get; set; }

        /// <summary>
        /// <para>If set to true, when the customer is charged, they will be sent a transaction receipt.</para>
        /// <para>Values: 'true' or 'false'</para>
        /// </summary>
        [ParameterName("customer_receipt")]
        public string CustomerReceipt { get; set; }

        /// <summary>
        /// Specifies a payment gateway transaction id in order to associate payment information with a Subscription record.
        /// </summary>
        [ParameterName("source_transaction_id")]
        public string SourceTransactionId { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class UpdateSubscription : AddSubscription
    {
        [ParameterName("recurring")]
        new internal static string Type => "update_subscription";

        /// <summary>
        /// The subscription ID that will be updated.
        /// </summary>
        [ParameterName("subscription_id")]
        public string SubscriptionId { get; set; }
    }

    /// <summary>
    /// Delete a subscription
    /// </summary>
    public class DeleteSubscription
    {
        [ParameterName("recurring")]
        internal static string Type => "delete_subscription";

        /// <summary>
        /// The subscription ID that will be deleted.
        /// </summary>
        [ParameterName("subscription_id")]
        public string SubscriptionId { get; set; }
    }
}
