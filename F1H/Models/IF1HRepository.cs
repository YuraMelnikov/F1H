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
        
        void AddTypeCalculate(TypeCalculate typeCalculate);
        void AddTypeTypeDNQ(TypeDNQ typeDNQ);
        void AddTypeTypeFail(TypeFail typeFail);
        void AddTypeTypeFinish(TypeFinish typeFinish);
        void AddImageGP(ImageGP imageGP);
        void AddImageGPConfiguration(ImageGPConfiguration imageGPConfiguration);
        void AddImageGPFlag(ImageGPFlag imageGpFlag);
        void AddImageGPLiver(ImageGPLiver imageGpLiver);
        void AddImageGPRacers(ImageGPRacers imageGpRacers);
        void AddSeason(Season season);
        void AddCountry(Country country);
        void AddManufacturer(Manufacturer manufacturer);
        void AddTrackСonfiguration(TrackСonfiguration trackСonfiguration);
        void AddTrack(Track track);
        void AddTeam(Team team);
        void AddTeamName(TeamName teamName);
        void AddChassi(Chassi chassi);
        void AddDescriptionResult(DescriptionResult descriptionResult);
        void AddDNQ(DNQ dnq);
        void AddEngine(Engine engine);
        void AddFail(Fail fail);
        void AddFastLap(FastLap fastLap);
        void AddGP(GP gp);
        void AddGPResult(GPResult gpResult);
        void AddLeaderLap(LeaderLap leaderLap);
        void AddParticipant(Participant participant);
        void AddPit(Pit pit);
        void AddQualification(Qualification qualification);
        void AddRacer(Racer racer);
        void AddStartPositionType(StartPositionType startPositionType);
        void AddTyre(Tyre tyre);

        void SaveChanges();
    }
}