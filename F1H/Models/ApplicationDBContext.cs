using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace F1H.Models
{
    public class ApplicationDbContext : DbContext
    {
        //Add-Migration -Name "ProjectMigration" -Context "ApplicationDbContext"
        //Update-Database -Context "ApplicationDbContext"

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TypeCalculate> TypeCalculates { get; set; }
        public DbSet<TypeDNQ> TypeDNQs { get; set; }
        public DbSet<TypeFail> TypeFails { get; set; }
        public DbSet<TypeFinish> TypeFinishes { get; set; }
        public DbSet<ImageGP> Images { get; set; }
        public DbSet<ImageGPTrackConfiguration> ImagesGPConfigurations { get; set; }
        public DbSet<ImageGPFlag> ImagesGPFlags { get; set; }
        public DbSet<ImageGPLivery> ImagesGPLivers { get; set; }
        public DbSet<ImageGPRacers> ImagesGPRacers { get; set; }

        public DbSet<Season> Seasons { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<TrackСonfiguration> TrackСonfigurations { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Chassi> Chassis { get; set; }
        public DbSet<DNQ> DNQs { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Fail> Fails { get; set; }
        public DbSet<FastLap> FastLaps { get; set; }
        public DbSet<GP> GPs { get; set; }
        public DbSet<GPResult> GPResults { get; set; }
        public DbSet<LeaderLap> LeaderLaps { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Pit> Pits { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Racer> Racers { get; set; }
        public DbSet<StartPositionType> StartPositionTypes { get; set; }
        public DbSet<Tyre> Tyres { get; set; }
    }
}
