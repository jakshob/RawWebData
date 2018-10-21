using System.ComponentModel.DataAnnotations.Schema;


namespace WebServer
{
    [Table("products")]
    public class Product
    {
        [Column("productid")]
        public int Id { get; set; }
		
		public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }

        [Column("productname")]
        public string Name { get; set; }
        [Column("categoryid")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
