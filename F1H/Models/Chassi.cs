using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class Chassi
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdManufacturer { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int IdImageGp { get; set; }
        [Required]
        public int IdImagesGpChassi { get; set; }

        [ForeignKey("IdManufacturer")]
        public  Manufacturer Manufacturer { get; set; }
        [ForeignKey("IdImageGp")]
        public ImageGP Image { get; set; }
        [ForeignKey("IdImageGpChassi")]
        public ImageGPLiver ImageLiver { get; set; }
    }
}
