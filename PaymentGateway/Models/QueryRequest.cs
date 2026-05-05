using PaymentGateway.Attributes;

namespace PaymentGateway.Models
{
    /// <summary>
    /// Parameters for querying transaction and reporting data via the Query API.
    /// Dates should be in YYYYMMDDHHMMSS format (UTC).
    /// </summary>
    public class QueryRequest
    {
        /// <summary>
        /// The type of report to retrieve.
        /// Values: 'transaction' (default), 'customer_vault', 'recurring', 'invoices'
        /// </summary>
        [ParameterName("report_type")]
        public string ReportType { get; set; }

        /// <summary>
        /// Return a specific transaction by its gateway transaction ID.
        /// </summary>
        [ParameterName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Filter results to transactions on or after this date.
        /// Format: YYYYMMDDHHMMSS (UTC)
        /// </summary>
        [ParameterName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// Filter results to transactions on or before this date.
        /// Format: YYYYMMDDHHMMSS (UTC)
        /// </summary>
        [ParameterName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// Filter by transaction condition.
        /// Values: 'pendingsettlement', 'complete', 'failed', 'canceled', 'unknown'
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Filter by payment type.
        /// Values: 'cc' (credit card), 'ck' (check/ACH)
        /// </summary>
        [ParameterName("transaction_type")]
        public string TransactionType { get; set; }

        /// <summary>
        /// Filter by action type.
        /// Values: 'sale', 'auth', 'capture', 'void', 'refund', 'credit'
        /// </summary>
        [ParameterName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// Filter by transaction amount. Format: x.xx
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Filter by customer email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Filter by customer first name.
        /// </summary>
        [ParameterName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Filter by customer last name.
        /// </summary>
        [ParameterName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Filter by order ID.
        /// </summary>
        [ParameterName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// Filter by purchase order number.
        /// </summary>
        [ParameterName("po_number")]
        public string PoNumber { get; set; }

        /// <summary>
        /// Filter by Customer Vault ID.
        /// </summary>
        [ParameterName("customer_vault_id")]
        public string CustomerVaultId { get; set; }

        /// <summary>
        /// Filter by credit card number (last 4 digits or masked number).
        /// </summary>
        [ParameterName("cc_number")]
        public string CardNumber { get; set; }

        /// <summary>
        /// Filter by credit card expiration date. Format: MMYY
        /// </summary>
        [ParameterName("cc_exp")]
        public string CardExpiration { get; set; }

        /// <summary>
        /// Filter by processor ID (for Multiple MID accounts).
        /// </summary>
        [ParameterName("processor_id")]
        public string ProcessorId { get; set; }

        /// <summary>
        /// Filter by settlement batch ID.
        /// </summary>
        [ParameterName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// Filter by invoice ID (used when report_type is 'invoices').
        /// </summary>
        [ParameterName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Filter by customer ID.
        /// </summary>
        [ParameterName("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Maximum number of results to return.
        /// </summary>
        [ParameterName("result_limit")]
        public string ResultLimit { get; set; }

        /// <summary>
        /// Order of results.
        /// Values: 'ASC', 'DESC'
        /// </summary>
        [ParameterName("result_order")]
        public string ResultOrder { get; set; }
    }
}
