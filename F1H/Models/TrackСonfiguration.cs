using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class TrackСonfiguration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdTracks { get; set; }
        [Required]
        public int IdSeasons { get; set; }
        [Required]
        public int IdImagesGpConfiguration { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public int IdImagesGp { get; set; }

        [ForeignKey("IdImagesGp")]
        public ImagesGP ImagesGp { get; set; }
        [ForeignKey("IdTracks")]
        public  Tracks Track { get; set; }
        [ForeignKey("IdSeasons")]
        public  Seasons Season { get; set; }
        [ForeignKey("IdImagesGpConfiguration")]
        public  ImagesGPConfiguration ImagesGpConfiguratione { get; set; }
    }
}
