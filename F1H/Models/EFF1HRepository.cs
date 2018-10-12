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
        
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        
        public void AddTypeCalculate(TypeCalculate typeCalculate)
        {
            context.Add(typeCalculate);
        }
        public void AddTypeTypeDNQ(TypeDNQ typeDNQ)
        {
            context.Add(typeDNQ);
        }
        public void AddTypeTypeFail(TypeFail typeFail)
        {
            context.Add(typeFail);
        }
        public void AddTypeTypeFinish(TypeFinish typeFinish)
        {
            context.Add(typeFinish);
        }
        public void AddImageGP(ImageGP imageGP)
        {
            context.Add(imageGP);
        }
        public void AddImageGPConfiguration(ImageGPConfiguration imageGPConfiguration)
        {
            context.Add(imageGPConfiguration);
        }
        public void AddImageGPFlag(ImageGPFlag imageGpFlag)
        {
            context.Add(imageGpFlag);
        }
        public void AddImageGPLiver(ImageGPLiver imageGpLiver)
        {
            context.Add(imageGpLiver);
        }
        public void AddImageGPRacers(ImageGPRacers imageGpRacers)
        {
            context.Add(imageGpRacers);
        }
        public void AddSeason(Season season)
        {
            context.Add(season);
        }
        public void AddCountry(Country country)
        {
            context.Add(country);
        }
        public void AddManufacturer(Manufacturer manufacturer)
        {
            context.Add(manufacturer);
        }
        public void AddTrackСonfiguration(TrackСonfiguration trackСonfiguration)
        {
            context.Add(trackСonfiguration);
        }
        public void AddTrack(Track track)
        {
            context.Add(track);
        }
        public void AddTeam(Team team)
        {
            context.Add(team);
        }
        public void AddTeamName(TeamName teamName)
        {
            context.Add(teamName);
        }
        public void AddChassi(Chassi chassi)
        {
            context.Add(chassi);
        }
        public void AddDescriptionResult(DescriptionResult descriptionResult)
        {
            context.Add(descriptionResult);
        }
        public void AddDNQ(DNQ dnq)
        {
            context.Add(dnq);
        }
        public void AddEngine(Engine engine)
        {
            context.Add(engine);
        }
        public void AddFail(Fail fail)
        {
            context.Add(fail);
        }
        public void AddFastLap(FastLap fastLap)
        {
            context.Add(fastLap);
        }
        public void AddGP(GP gp)
        {
            context.Add(gp);
        }
        public void AddGPResult(GPResult gpResult)
        {
            context.Add(gpResult);
        }
        public void AddLeaderLap(LeaderLap leaderLap)
        {
            context.Add(leaderLap);
        }
        public void AddParticipant(Participant participant)
        {
            context.Add(participant);
        }
        public void AddPit(Pit pit)
        {
            context.Add(pit);
        }
        public void AddQualification(Qualification qualification)
        {
            context.Add(qualification);
        }
        public void AddRacer(Racer racer)
        {
            context.Add(racer);
        }
        public void AddStartPositionType(StartPositionType startPositionType)
        {
            context.Add(startPositionType);
        }
        public void AddTyre(Tyre tyre)
        {
            context.Add(tyre);
        }


    }
}
