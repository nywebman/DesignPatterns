using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Repository
{
    public class HotelContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
