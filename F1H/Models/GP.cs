using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace F1H.Models
{
    public class GP
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdTracks { get; set; }
        [Required]
        public int Num { get; set; }
        [Required]
        public int NumInSeason { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int IdImagesGp { get; set; }
        [Required]
        public string Weather { get; set; }
        [Required]
        public float PercentDistance { get; set; }
        [Required]
        public int IdStartPositionType { get; set; }

        [ForeignKey("IdTracks")]
        public  Tracks Track { get; set; }
        [ForeignKey("IdImagesGp")]
        public  ImagesGP Image { get; set; }
        [ForeignKey("IdStartPositionType")]
        public  StartPositionType StartType { get; set; }
    }
}
