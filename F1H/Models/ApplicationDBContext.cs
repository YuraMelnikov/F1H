using Microsoft.EntityFrameworkCore;

namespace F1H.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<TypeCalculate> TypeCalculates { get; set; }
        //public DbSet<TypeDNQ> TypeDNQs { get; set; }
        //public DbSet<TypeFail> TypeFails { get; set; }
        //public DbSet<TypeFinish> TypeFinishes { get; set; }

        //public DbSet<Chassi> Chassis { get; set; }
        //public DbSet<Country> Country { get; set; }
        //public DbSet<DescriptionResult> DescriptionResults { get; set; }
        //public DbSet<DNQ> DNQs { get; set; }
        //public DbSet<Engine> Engines { get; set; }
        //public DbSet<Fail> Fails { get; set; }
        //public DbSet<FastLap> FastLaps { get; set; }
        //public DbSet<GP> GPs { get; set; }
        //public DbSet<GPResult> GPResults { get; set; }
        //public DbSet<ImageGP> Images { get; set; }
        //public DbSet<ImageGPConfiguration> ImagesGPConfigurations { get; set; }
        //public DbSet<ImageGPFlag> ImagesGPFlags { get; set; }
        //public DbSet<ImageGPLiver> ImagesGPLivers { get; set; } 
        //public DbSet<ImageGPRacers> ImagesGPRacers { get; set; }
        //public DbSet<LeaderLap> LeaderLaps { get; set; }
        //public DbSet<Manufacturer> Manufacturers { get; set; }
        //public DbSet<Participant> Participants { get; set; }
        //public DbSet<Pit> Pits { get; set; }
        //public DbSet<Qualification> Qualifications { get; set; }
        //public DbSet<Racer> Racers { get; set; }
        //public DbSet<Season> Seasons { get; set; }
        //public DbSet<StartPositionType> StartPositionTypes { get; set; }
        //public DbSet<TeamName> TeamNames { get; set; }
        //public DbSet<Team> Teams { get; set; }
        //public DbSet<Track> Tracks { get; set; }
        //public DbSet<TrackСonfiguration> GetTrackСonfigurations { get; set; }
        //public DbSet<Tyre> Tyres { get; set; }
    }
}
