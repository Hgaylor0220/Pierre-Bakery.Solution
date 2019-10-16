using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pierre_Bakery.Models;



namespace Pierre_Bakery.Controllers
{
    public class VendorOrderController : Controller
    {
        [HttpGet("/vendor")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

    
        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendor")]
        public ActionResult Create(string vendorName, string vendorDescription, int Id)
        {            
            Vendor newVendor = new Vendor(vendorName, vendorDescription, Id);
            return RedirectToAction("Index");
        }

    //     [HttpPost("/vendorlist")]
    //     public ActionResult Index(string vendorName, string vendorDescription)
    //     {
    //         Vendor newvendor = new Vendor(vendorName, vendorDescription);
    //         List<Vendor> vendorOrder = newvendor.VendorOrder;d

    //         return View("Index", vendorOrder);
    //     }

    //     [HttpPost("/vendororders")]
    //     public ActionResult Index(string orderTitle, string orderDiscription, int price)
    //     {

    //         Order newOrder = new Order(orderTitle, orderDiscription, price);
    //         List<Order> Orders = newOrder.Orders;


    //          return View("Index", Orders);

    //     }

    

    }
}