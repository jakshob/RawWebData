﻿using WebServer;

namespace DataService
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
