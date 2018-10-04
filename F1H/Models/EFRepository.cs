using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1H.Models
{
    public class EFRepository : IRepository
    {
        private ApplicationDbContext context;
        public EFRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        
        public IQueryable<GP> GpQueryable => context.GpQueryable;
        public IQueryable<FastLap> FastLaps => context.FastLaps;
        public IQueryable<Fail> Fails => context.Fails;
        public IQueryable<Engines> Engineses => context.Engineses;
        public IQueryable<DNQ> DNQs => context.DNQs;
        public IQueryable<DescriptionResult> DescriptionResults => context.DescriptionResults;
        public IQueryable<Country> Countries => context.Countries;
    }
}
