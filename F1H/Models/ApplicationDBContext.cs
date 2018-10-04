using Microsoft.EntityFrameworkCore;

namespace F1H.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<GP> GpQueryable { get; }
        public DbSet<FastLap> FastLaps { get; }
        public DbSet<Fail> Fails { get; }
        public DbSet<Engines> Engineses { get; }
        public DbSet<DNQ> DNQs { get; }
        public DbSet<DescriptionResult> DescriptionResults { get; }
        public DbSet<Country> Countries { get; }
    }
}
