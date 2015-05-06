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
        private DAL.BillingSystemEntities _bsEntities = new BillingSystemEntities();

        [Display(Name = "Expense Name")]
        public string Expense { get; set; }
        
        public string Description { get; set; }

        [Display(Name = "Monthly Est. Dues")]
        public double MonthlyEstimatedDues { get; set; }

        [Display(Name = "Interest Rate")]
        public double InterestRate { get; set; }

        [Display(Name = "Payment Due Date")]
        public DateTime DueDate { get; set; }

        public void InsertNewPayment()
        {
            var newPayment = new DAL.Payment();
            newPayment.Description = this.Description;
            newPayment.DueDate = this.DueDate;
            newPayment.Expense = this.Expense;
            newPayment.InterestRate = this.InterestRate;
            newPayment.MonthlyEstDues = this.MonthlyEstimatedDues;
            newPayment.Timestamp = DateTime.Now;

            _bsEntities.Payments.Add(newPayment);
            _bsEntities.SaveChanges();
        }
    }
}