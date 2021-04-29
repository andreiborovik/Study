using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Categories Category;
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public List<Orders> Orders { get; set; } = new List<Orders>();
    }
}
