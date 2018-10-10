using System.Linq;

namespace F1H.Models
{
    public interface IF1HRepository
    {
        IQueryable<TypeCalculate> TypeCalculates { get; }
        IQueryable<TypeDNQ> TypeDNQs { get; }
        IQueryable<TypeFail> TypeFails { get; }
        IQueryable<TypeFinish> TypeFinishes { get; }
        IQueryable<ImageGP> Images { get; }
        IQueryable<ImageGPConfiguration> ImagesGPConfigurations { get; }
        IQueryable<ImageGPFlag> ImagesGPFlags { get; }
        IQueryable<ImageGPLiver> ImagesGPLivers { get; }
        IQueryable<ImageGPRacers> ImagesGPRacers { get; }

        IQueryable<Season> Seasons { get; }
        IQueryable<Country> Country { get; }
        IQueryable<Manufacturer> Manufacturers { get; }
        IQueryable<TrackСonfiguration> GetTrackСonfigurations { get; }
        IQueryable<Track> Tracks { get; }
        IQueryable<Team> Teams { get; }
        IQueryable<TeamName> TeamNames { get; }

        IQueryable<Chassi> Chassis { get; }
        IQueryable<DescriptionResult> DescriptionResults { get; }
        IQueryable<DNQ> DNQs { get; }
        IQueryable<Engine> Engines { get; }
        IQueryable<Fail> Fails { get; }
        IQueryable<FastLap> FastLaps { get; }
        IQueryable<GP> GPs { get; }
        IQueryable<GPResult> GPResults { get; }
        IQueryable<LeaderLap> LeaderLaps { get; }
        IQueryable<Participant> Participants { get; }
        IQueryable<Pit> Pits { get; }
        IQueryable<Qualification> Qualifications { get; }
        IQueryable<Racer> Racers { get; }
        IQueryable<StartPositionType> StartPositionTypes { get; }
        IQueryable<Tyre> Tyres { get; }
    }
}