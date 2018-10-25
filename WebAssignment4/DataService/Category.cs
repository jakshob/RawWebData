using System.ComponentModel.DataAnnotations.Schema;

namespace WebServer
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
