using System;
using System.Collections.Generic;

namespace DataLayer.Entity
{
    public class Order
    {
        public int id { get; set; }
        //   public int user_id { get; set; }
        public DateTime date_time { get; set; }
        public double total_price { get; set; }
        public User User { get; set; }
        public List<Product> ProductList { get; set; }

    }
}