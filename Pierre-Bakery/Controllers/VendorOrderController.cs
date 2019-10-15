using Microsoft.AspNetCore.Mvc;
using Order.Models;
using Vendor.Models;
using System.Collections.Generic;

namespace VendorOrder.Controller
{
    public class VendorOrderController : Controller
    {
        [HttpGet("/vendororder/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendororder")]
        public ActionResult Index(string vendorName, string vendorDiscription)
        {
            Vendor newvendor = new Vendor(vendorName, vendorDiscription);
            List<Vendor> vendorOrder = newvendor.VendorOrder;


            return View("Index", vendorOrder);
        }

    

    }
}