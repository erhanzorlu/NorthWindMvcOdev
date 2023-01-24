using System.Collections.Generic;

namespace MVC_Layout.Models.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
