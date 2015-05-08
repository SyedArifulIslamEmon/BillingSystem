using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillingSystem.BLL.Models;
using BillingSystem.UI.Models;

namespace BillingSystem.UI.Controllers
{
    public class PaymentController : Controller
    {
        private PaymentRepository payRep = new PaymentRepository();

        // GET: Payment
        public ActionResult ManagePayments()
        {
            var payments = payRep.RetrievePayments();
            return View(payments);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PaymentViewModel payViewModel)
        {
            payRep.InsertNewPayment(payViewModel);
            return RedirectToAction("ManagePayments");
        }

        public ActionResult Edit(int id = 0)
        {
            var payment = payRep.RetrievePayment(id);

            if (payment == null)
                return HttpNotFound();

            return View(payment);
        }

        [HttpPost]
        public ActionResult Edit(PaymentViewModel paymentVM)
        {
            var res = payRep.UpdatePayment(paymentVM);

            if (!res)
                return HttpNotFound();

            return RedirectToAction("ManagePayments");
        }
        
        [HttpPost]
        public string Delete(int id)
        {
            payRep.DeletePayment(id);
            return "deleted";
        }
    }
} 