using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillingSystem.DAL;

namespace BillingSystem.BLL.Models
{
    public class PaymentViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int PaymentId { get; set; }

        [Display(Name = "Expense Name")]
        [Required(ErrorMessage = "Required")]
        public string Expense { get; set; }
        
        public string Description { get; set; }

        [Display(Name = "Monthly Est. Dues")]
        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Required")]
        public double MonthlyEstimatedDues { get; set; }

        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        [Range(0,1)]
        [Display(Name = "Interest Rate")]
        public double? InterestRate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "Payment Due Date")]
        public DateTime? DueDate { get; set; }
    }
}