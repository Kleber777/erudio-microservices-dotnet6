using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.IdentityServer.Model.Context
{
    public class SqlServerContext : IdentityDbContext<ApplicationUser>
    {
        protected readonly IConfiguration Configuration;

        public SqlServerContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("SqlConnectionString"));
        }
        //public DbSet<Product> Products { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData(
        //        new Product
        //        {
        //            Id = 3,
        //            Name = "Name 3",
        //            Price = 69.9M,
        //            Describe = "Nome + o número",
        //            ImageUrl = "Imagem para URL 3",
        //            CategoryName = "categoria 3"
        //        }
        //        );

        //    modelBuilder.Entity<Product>().HasData(
        //        new Product
        //        {
        //            Id = 4,
        //            Name = "Name 4",
        //            Price = 69.9M,
        //            Describe = "Nome + o número",
        //            ImageUrl = "Imagem para URL 4",
        //            CategoryName = "categoria 4"
        //        }
        //        );
        //}
    }
}
