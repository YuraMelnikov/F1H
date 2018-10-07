using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class Pit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdGpResult { get; set; }
        [Required]
        public int Lap { get; set; }

        [ForeignKey("IdGpResult")]
        public GPResult Result { get; set; }
    }
}
