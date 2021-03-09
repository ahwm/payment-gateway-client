using PaymentGateway.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Models
{
    public class RecurringPlan
    {
        [ParameterName("plan_payments")]
        public int PlanPayments { get; set; }

        [ParameterName("plan_amount")]
        public decimal PlanAmount { get; set; }

        [ParameterName("plan_id")]
        public string PlanId { get; set; }

        [ParameterName("day_frequency")]
        public int? DayFrequency { get; set; }

        [ParameterName("month_frequency")]
        public int? MonthFrequency { get; set; }

        [ParameterName("day_of_month")]
        public int? DayOfMonth { get; set; }

        [ParameterName("current_plan_id")]
        public string CurrentPlanId { get; set; }
    }
}
