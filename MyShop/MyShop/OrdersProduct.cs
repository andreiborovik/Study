using System;
using System.Collections.Generic;

#nullable disable

namespace MyShop
{
    public partial class OrdersProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
