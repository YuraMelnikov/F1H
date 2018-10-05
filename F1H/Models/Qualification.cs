using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class Qualification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdParticipants { get; set; }
        [Required]
        public string Num { get; set; }
        [Required]
        public int Position { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public float AverageSpeed { get; set; }

        [ForeignKey("IdParticipants")]
        public  Participants Participant { get; set; }
    }
}
