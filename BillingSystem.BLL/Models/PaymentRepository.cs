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

        public List<PaymentViewModel> RetrievePayments()
        {
            var payments = _bsEntities.Payments.ToList();

            var payLst = new List<PaymentViewModel>();

            foreach (var payment in payments)
            {
                payLst.Add(new PaymentViewModel
                {
                    PaymentId = payment.PaymentId,
                    Description = payment.Description,
                    DueDate = payment.DueDate,
                    Expense = payment.Expense,
                    InterestRate = payment.InterestRate,
                    MonthlyEstimatedDues = payment.MonthlyEstDues
                });
            }
            return payLst;
        }

        public PaymentViewModel RetrievePayment(int paymentId)
        {
            var payment = _bsEntities.Payments.FirstOrDefault(x => x.PaymentId == paymentId);

            if (payment == null)
                return null;
                
            return new PaymentViewModel()
                   {
                       PaymentId =  payment.PaymentId,
                       Description = payment.Description,
                       Expense = payment.Expense,
                       InterestRate = payment.InterestRate,
                       DueDate = payment.DueDate,
                       MonthlyEstimatedDues = payment.MonthlyEstDues
                   };
        }

        public bool RemovePayment(PaymentViewModel payVM)
        {
            var payment = _bsEntities.Payments.FirstOrDefault(x => x.PaymentId == payVM.PaymentId);

            if (payment == null)
                return false;

            _bsEntities.Payments.Remove(payment);
            _bsEntities.SaveChanges();
            return true;
        }

        public bool UpdatePayment(PaymentViewModel payVM)
        {
            var payment = _bsEntities.Payments.FirstOrDefault(x => x.PaymentId == payVM.PaymentId);

            if (payment == null)
                return false;

            payment.Description = payVM.Description;
            payment.DueDate = payVM.DueDate;
            payment.Expense = payVM.Expense;
            payment.InterestRate = payVM.InterestRate;
            payment.MonthlyEstDues = payVM.MonthlyEstimatedDues;
            _bsEntities.SaveChanges();
            return true;
        }
    }
}
