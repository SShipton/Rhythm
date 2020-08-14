
using Microsoft.EntityFrameworkCore;

namespace Band
{
    class BandContext : DbContext
    {
        public DbSet<BandContext> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;database=Album");
        }
    }
}