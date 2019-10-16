using System.Collections.Generic;

namespace Pierre_Bakery.Models
{
    public class Order
    {

        public int Date { get; set;}
        public string Title { get; set;}
        public string Discription { get; set;}
        public int Price { get; set;}
        public int ID { get; }

        private static List<Order> _orders = new List<Order> { };

        public Order(string orderTitle , string orderDiscription, int price, int date, int Id)
        {
            Title = orderTitle;
            Discription = orderDiscription;
            Date = date;
            Price = price;
            _orders.Add(this);
            Id = _orders.Count;
            _orders = new List<Order> { };
        }
        public static int OrderTotal(int price)
        {
            return price;
        }
        
        public static List<Order> GetAll()
        {
            return _orders;
        }

        public static void ClearAll()
        {
            _orders.Clear();
        }

        public static Order Find(int searchID)
        {
            return _orders[searchID - 1];
        }
    }
    
}
