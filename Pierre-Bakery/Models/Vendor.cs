using System.Collections.Generic;

namespace Pierre_Bakery.Models 
{ 
    public class Vendor
    {

        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; }


        private static List<Vendor> _vendorOrders = new List<Vendor> { };
        public static int idAssigner { get; set; }

        public Vendor(string vendorName, string vendorDescription, int Id )
        {
            Name = vendorName;
            Description = vendorDescription;
            _vendorOrders.Add(this);
            Id = _vendorOrders.Count;
            Orders = new List<Order> { };
        }

        public static List<Vendor> GetAll()
        {
            return _vendorOrders;
        }

        public static void ClearAll()
        {
            _vendorOrders.Clear();
        }

        public static Vendor Find(int searchID)
        {
            return _vendorOrders[searchID - 1];
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }

}