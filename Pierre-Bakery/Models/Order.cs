using System.Collections.Generic;
using Vendor.Models;

namespace Order.Models
{
    public class Order
    {

        public int Date { get; set;}
        public string Title { get; set;}
        public string Discription { get; set;}
        public int Price { get; set;}
        public int ID { get; }

        public static List<Order> Orders = new List<Order> { };

        public Order(string orderTitle , string orderDiscription, int price, int date, int Id)
        {
            Title = orderTitle;
            Discription = orderDiscription;
            Date = date;
            Price = price;
            Orders.Add(this);
            Id = Orders.Count;
            Orders = new List<Order> { };
        }
        public static int OrderTotal(int price)
        {
            return price;
        }
        
        public static List<Order> GetAll()
        {
            return Orders;
        }

        public static void ClearAll()
        {
            Orders.Clear();
        }

        public static Order Find(int searchID)
        {
            return Orders[searchID - 1];
        }
    }
    
}
