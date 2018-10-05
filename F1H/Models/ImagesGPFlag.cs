using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class ImagesGPFlag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Link { get; set; }
    }
}
