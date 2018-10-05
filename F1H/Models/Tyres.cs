using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class Tyres
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdManufacturers { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int IdImagesGp { get; set; }

        [ForeignKey("IdImagesGp")]
        public ImagesGP ImagesGp { get; set; }
        [ForeignKey("IdManufacturers")]
        public  Manufacturers Manufacturer { get; set; }
    }
}
