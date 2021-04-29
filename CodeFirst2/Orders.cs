using System.Collections.Generic;
namespace CodeFirst2
{
    class Orders
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
