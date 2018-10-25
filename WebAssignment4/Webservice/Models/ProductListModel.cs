using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webservice.Models
{
    public class ProductListModel
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Category { get; set; }
    }
}
