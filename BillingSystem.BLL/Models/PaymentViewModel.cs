﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillingSystem.BLL.Models
{
    public class PaymentViewModel
    {
        [Display(Name = "Expense Name")]
        public string Expense { get; set; }
        
        public string Description { get; set; }

        [Display(Name = "Monthly Est. Dues")]
        public double MonthlyEstimatedDues { get; set; }

        [Display(Name = "Interest Rate")]
        public double InterestRate { get; set; }

        [Display(Name = "Payment Due Date")]
        public DateTime DueDate { get; set; }
    }
}