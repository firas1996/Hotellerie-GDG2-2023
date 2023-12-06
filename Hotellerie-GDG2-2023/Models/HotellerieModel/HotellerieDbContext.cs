using Microsoft.EntityFrameworkCore;

namespace Hotellerie_GDG2_2023.Models.HotellerieModel
{
    public class HotellerieDbContext : DbContext
    {
        public HotellerieDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; } = null!;
    }
}
