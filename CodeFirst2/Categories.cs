using System.Collections.Generic;

namespace CodeFirst2
{
    class Categories
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<Product> Products = new List<Product>();
    }
}
