using System;

namespace F1H.Models
{
    public class GP
    {
        public int Id { get; }
        public int IdTracks { get; }
        public int Num { get; }
        public int NumInSeason { get; }
        public DateTime Date { get; }
        public string Name { get; }
        public int IdImagesGp { get; }
        public string Weather { get; }
        public float PercentDistance { get; }
        public int IdStartPositionType { get; }
    }
}
