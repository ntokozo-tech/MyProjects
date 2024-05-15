using Microsoft.EntityFrameworkCore;
using Team8WebAPI.Models;

namespace Team8WebAPI.data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Users> users { get; set; }
        public DbSet<Food> food { get; set; }
        public DbSet<Cart> cart { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Driver> drivers { get; set; }
        public DbSet<CustomerPointsStats> customerPointsStats { get; set; }

        public DbSet<Rating> ratings { get; set; }
        //public DbSet<DriverTrackOrder> driverTrackOrders { get; set; }

        public DbSet<Deliveries> deliveries { get; set; }

        public DbSet<Card> cards { get; set; }
    }
}
