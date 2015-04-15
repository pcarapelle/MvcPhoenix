using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPhoenix.Controllers
{
    public class ServiceController : Controller
    {
        // GET: /Service
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Service/Order
        public ActionResult Order()
        {
            return View();
        }

        // GET: /Service/ImportOrder
        public ActionResult ImportOrder()
        {
            return View();
        }

        // GET: /Service/ProductProfile
        public ActionResult ProductProfile()
        {
            return View("~/Views/Product/ProductProfile.cshtml");
        }

        // GET: /Service/PackoutStatus
        public ActionResult PackoutStatus()
        {
            return View("~/Views/Production/PackoutStatus.cshtml");
        }

        // GET: /Service/Report
        public ActionResult Report()
        {
            return View();
        }
    }
}