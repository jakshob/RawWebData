using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebServer
{
    [Table("orders")]
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public DateTime Required { get; set; }
        public Nullable<DateTime> Shipped { get; set; }

        public int Freight { get; set; }

        public string ShipName { get; set; }
        public string ShipCity { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
    }
}
