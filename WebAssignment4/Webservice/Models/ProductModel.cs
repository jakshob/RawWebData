using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class ProductModel
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
    }
}
