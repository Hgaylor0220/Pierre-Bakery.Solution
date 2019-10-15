using Microsoft.AspNetCore.Mvc;
using Order.Models;
using Vendor.Models;
using System.Collections.Generic;

namespace VendorOrder.Controller
{
    public class VendorOrderController : Controller
    {
        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpGet("/vendor/{id}")]
        public ActionResult Show(int id)
        {
            
            Vendor currentVendor = Vendor.Find(id);
            List<Order> vendorOrder = currentVendor.Order;
            model.Add("vendor", currentVendor);
            model.Add("order", vendorOrder);
            return View(model);
        }

        [HttpPost("/vendorlist")]
        public ActionResult Index(string vendorName, string vendorDiscription)
        {
            Vendor newvendor = new Vendor(vendorName, vendorDiscription);
            List<Vendor> vendorOrder = newvendor.VendorOrder;

            return View("Index", vendorOrder);
        }

        [HttpPost("/vendororders")]
        public ActionResult Index(string orderTitle, string orderDiscription, int price)
        {

            Order newOrder = new Order(orderTitle, orderDiscription, price);
            List<Order> Orders = newOrder.Orders;


             return View("Index", Orders);

        }

    

    }
}