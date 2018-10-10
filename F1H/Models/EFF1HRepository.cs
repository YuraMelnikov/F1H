using System.Linq;

namespace F1H.Models
{
    public class EFF1HRepository : IF1HRepository
    {
        private ApplicationDbContext context;
        public EFF1HRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<TypeCalculate> TypeCalculates => context.TypeCalculates;
        public IQueryable<TypeDNQ> TypeDNQs => context.TypeDNQs;
        public IQueryable<TypeFail> TypeFails => context.TypeFails;
        public IQueryable<TypeFinish> TypeFinishes => context.TypeFinishes;
        public IQueryable<ImageGP> Images => context.Images;
        public IQueryable<ImageGPConfiguration> ImagesGPConfigurations => context.ImagesGPConfigurations;
        public IQueryable<ImageGPFlag> ImagesGPFlags => context.ImagesGPFlags;
        public IQueryable<ImageGPLiver> ImagesGPLivers => context.ImagesGPLivers;
        public IQueryable<ImageGPRacers> ImagesGPRacers => context.ImagesGPRacers;
        
        public IQueryable<Season> Seasons => context.Seasons;
        public IQueryable<Country> Country => context.Country;
        public IQueryable<Manufacturer> Manufacturers => context.Manufacturers;
        public IQueryable<TrackСonfiguration> GetTrackСonfigurations => context.GetTrackСonfigurations;
        public IQueryable<Track> Tracks => context.Tracks;
        public IQueryable<Team> Teams => context.Teams;
        public IQueryable<TeamName> TeamNames => context.TeamNames;

        public IQueryable<Chassi> Chassis => context.Chassis;
        public IQueryable<DescriptionResult> DescriptionResults => context.DescriptionResults;
        public IQueryable<DNQ> DNQs => context.DNQs;
        public IQueryable<Engine> Engines => context.Engines;
        public IQueryable<Fail> Fails => context.Fails;
        public IQueryable<FastLap> FastLaps => context.FastLaps;
        public IQueryable<GP> GPs => context.GPs;
        public IQueryable<GPResult> GPResults => context.GPResults;
        public IQueryable<LeaderLap> LeaderLaps => context.LeaderLaps;
        public IQueryable<Participant> Participants => context.Participants;
        public IQueryable<Pit> Pits => context.Pits;
        public IQueryable<Qualification> Qualifications => context.Qualifications;
        public IQueryable<Racer> Racers => context.Racers;
        public IQueryable<StartPositionType> StartPositionTypes => context.StartPositionTypes;
        public IQueryable<Tyre> Tyres => context.Tyres;
    }
}
