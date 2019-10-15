using System.Collections.Generic;
using Order.Models;

namespace Vendor.Models 
{
    public class Vendor
    {

        public int ID { get; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public List<Order> Orders { get; set; }


        public static List<Vendor> VendorOrders = new List<Vendor> { };
        public static int idAssigner { get; set; }

        public Vendor(string vendorName, string vendorDiscription, int Id )
        {
            Name = vendorName;
            Discription = vendorDiscription;
            VendorOrders.Add(this);
            Id = VendorOrders.Count;
            Orders = new List<Order> { };
        }

        public static List<Vendor> GetAll()
        {
            return VendorOrders;
        }

        public static void ClearAll()
        {
            VendorOrders.Clear();
        }

        public static Vendor Find(int searchID)
        {
            return VendorOrders[searchID - 1];
        }
    }

}