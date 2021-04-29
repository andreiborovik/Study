using System;
using System.Collections.Generic;

#nullable disable

namespace MyShop
{
    public partial class Product
    {
        public Product()
        {
            Comments = new HashSet<Comment>();
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
