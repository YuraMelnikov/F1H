using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NameEn { get; set; }
        [Required]
        public string NameRus { get; set; }
        [Required]
        public int IdImagesGpFlag { get; set; }

        [ForeignKey("IdImagesGpFlag")]
        public  ImagesGPFlag Image { get; set; }
    }
}
