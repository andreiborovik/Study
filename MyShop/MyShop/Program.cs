using System;
using System.Linq;

namespace MyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ShopContext db = new ShopContext())
            {
                Category food = new Category { Name = "Food" };
                Category clothers = new Category { Name = "Ckothers" };
                Product apple = new Product { Name = "Apple", Price = 1.09M, Category = food };
                Product melon = new Product { Name = "Melon", Price = 1.78M, Category = food };
                Product hat = new Product { Name = "Hat", Price = 1.432M, Category = clothers };
                Product jeans = new Product { Name = "Jeans", Price = 4.242M, Category = clothers };
                db.Categories.AddRange(food, clothers);
                db.Products.AddRange(apple, melon, hat, jeans);
                var food1 = db.Categories.FirstOrDefault();
                db.Categories.Remove(food1);
                User andrei = new User
                {
                    Firstname = "Andrei",
                    Lastname = "Borovik",
                    Birthday = new DateTime(2000, 10, 7),
                    Email = "andrei.borovik2000@yandex.by",
                    Phone = "80292085750"
                };
                db.Users.Add(andrei);
                Role admin = new Role { Name = "Admin" };
                db.Roles.Add(admin);
                admin.UsersRoles.Add(new UsersRole { User = andrei });
                var product = db.Products.FirstOrDefault();
                Comment comment1 = new Comment { Text = "Good!", Product = product };
                db.Comments.Add(comment1);
                var product2 = db.Products.Find(5);
                var user = db.Users.FirstOrDefault();
                Order order = new Order { User = user };
                order.OrdersProducts.Add(new OrdersProduct { Product = product });
                order.OrdersProducts.Add(new OrdersProduct { Product = product2 });
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }
    }
}
