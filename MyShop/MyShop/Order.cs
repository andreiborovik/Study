using System;
using System.Collections.Generic;

#nullable disable

namespace MyShop
{
    public partial class Order
    {
        public Order()
        {
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
