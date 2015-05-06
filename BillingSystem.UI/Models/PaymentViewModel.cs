using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillingSystem.UI.Models
{
    public class PaymentViewModel
    {
        public string Expense { get; set; }
        public string Description { get; set; }
        public double MonthlyEstimatedDues { get; set; }
        public double InterestRate { get; set; }
        public DateTime DueDate { get; set; }
    }
}