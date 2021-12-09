using PaymentGateway.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class RecurringPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [ParameterName("plan_payments")]
        public int PlanPayments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("plan_amount")]
        public decimal PlanAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("day_frequency")]
        public int? DayFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("month_frequency")]
        public int? MonthFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("day_of_month")]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ParameterName("current_plan_id")]
        public string CurrentPlanId { get; set; }
    }
}
