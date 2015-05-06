using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem.DAL;

namespace BillingSystem.BLL.Models
{
    public class PaymentRepository
    {
        private DAL.BillingSystemEntities _bsEntities = new BillingSystemEntities();

        public void InsertNewPayment(PaymentViewModel payVM)
        {
            var newPayment = new DAL.Payment();
            newPayment.Description = payVM.Description;
            newPayment.DueDate = payVM.DueDate;
            newPayment.Expense = payVM.Expense;
            newPayment.InterestRate = payVM.InterestRate;
            newPayment.MonthlyEstDues = payVM.MonthlyEstimatedDues;
            newPayment.Timestamp = DateTime.Now;

            _bsEntities.Payments.Add(newPayment);
            _bsEntities.SaveChanges();
        }

        public List<PaymentViewModel> GetPayments()
        {
            var payments = _bsEntities.Payments.ToList();

            var payLst = new List<PaymentViewModel>();

            foreach (var payment in payments)
            {
                payLst.Add(new PaymentViewModel
                {
                    Description = payment.Description,
                    DueDate = payment.DueDate,
                    Expense = payment.Expense,
                    InterestRate = payment.InterestRate,
                    MonthlyEstimatedDues = payment.MonthlyEstDues
                });
            }
            return payLst;
        }
    }
}
