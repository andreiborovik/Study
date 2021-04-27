using Microsoft.EntityFrameworkCore;

namespace CodeFirst2
{
    class ShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Categories> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public ShopContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-RRC41OD\\SQLEXPRESS;Database=CodeFirst2;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().Property(b => b.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Categories>().HasKey(b => b.CategoryId);
            modelBuilder.Entity<Comment>().HasOne(j => j.Product).WithMany(s => s.Comments).HasForeignKey(j => j.ProductId);
            modelBuilder.Entity<Product>().HasOne(j => j.Category).WithMany(s => s.Products).HasForeignKey(j => j.CategoryId);
            modelBuilder.Entity<Orders>().HasKey(s => s.OrderId);
            modelBuilder.Entity<Orders>().HasOne(j => j.Users).WithMany(s => s.Orders).HasForeignKey(j => j.UserId);
        }
    }
}
