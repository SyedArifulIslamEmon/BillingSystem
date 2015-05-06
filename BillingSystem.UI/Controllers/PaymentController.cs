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
        // GET: Payment
        public ActionResult ManagePayments()
        {
            var payments = new List<PaymentViewModel>();
            return View(payments);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PaymentViewModel payViewModel)
        {
            payViewModel.InsertNewPayment();
            return RedirectToAction("ManagePayments");
        }
    }
}