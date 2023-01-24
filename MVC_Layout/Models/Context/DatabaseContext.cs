using Microsoft.EntityFrameworkCore;
using MVC_Layout.Models.Entity;

namespace MVC_Layout.Models.Context
{
    public class DatabaseContext:DbContext
    {
        public  DbSet<User> Users { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost;database=MvcDenemeDb; TrustServerCertificate=true;Trusted_connection=True");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
