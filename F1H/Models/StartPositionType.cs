using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class StartPositionType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Map { get; set; }
        [Required]
        public int IdImagesGp { get; set; }

        [ForeignKey("IdImagesGp")]
        public  ImagesGP Image { get; set; }
    }
}
