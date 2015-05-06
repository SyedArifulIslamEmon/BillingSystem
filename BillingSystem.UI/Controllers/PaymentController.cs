using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillingSystem.UI.Models;

namespace BillingSystem.UI.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult ManageBilling()
        {
            var payments = new List<PaymentViewModel>();
            return View(payments);
        }
    }
}