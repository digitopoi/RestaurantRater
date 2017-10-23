using System.Data.Entity;

namespace RestaurantRater.Models
{
    public class RestaurantDBContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}