using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BillingSystem.DAL;

namespace BillingSystem.BLL.Models
{
    public class PaymentViewModel
    {
        public int PaymentId { get; set; }

        [Display(Name = "Expense Name")]
        public string Expense { get; set; }
        
        public string Description { get; set; }

        [Display(Name = "Monthly Est. Dues")]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public double? MonthlyEstimatedDues { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Interest Rate")]
        public double? InterestRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Payment Due Date")]
        public DateTime? DueDate { get; set; }
    }
}