using System.Linq;

namespace F1H.Models
{
    public interface IRepository
    {
        IQueryable<GP> GpQueryable { get; }
        IQueryable<FastLap> FastLaps { get; }
        IQueryable<Fail> Fails { get; }
        IQueryable<Engines> Engineses { get; }
        IQueryable<DNQ> DNQs { get; }
        IQueryable<DescriptionResult> DescriptionResults { get; }
        IQueryable<Country> Countries { get; }
    }
}