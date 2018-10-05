using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class Seasons
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int IdImagesGp { get; set; }
        [Required]
        public int IdTypeCalculate { get; set; }

        [ForeignKey("IdImagesGp")]
        public ImagesGP Image { get; set; }
        [ForeignKey("IdTypeCalculate")]
        public TypeCalculate TypeCalculat { get; set; }
    }
}
