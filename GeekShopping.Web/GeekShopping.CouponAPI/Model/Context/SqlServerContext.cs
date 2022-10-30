using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CouponAPI.Model
{
    public class SqlServerContext : DbContext
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
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                Id = 1,
                CouponCode = "ERUDIO_2022_10",
                DiscountAmount = 10
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                Id = 2,
                CouponCode = "ERUDIO_2022_15",
                DiscountAmount = 15
            });
        }

    }
}
