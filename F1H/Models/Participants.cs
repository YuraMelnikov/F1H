using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class Participants
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdGp { get; set; }
        [Required]
        public string Num { get; set; }
        [Required]
        public int IdTeams { get; set; }
        [Required]
        public int IdChassis { get; set; }
        [Required]
        public int IdEngines { get; set; }
        [Required]
        public int IdRacers { get; set; }
        [Required]
        public int IdTyres { get; set; }

        [ForeignKey("IdGp")]
        public  GP Gp { get; set; }
        [ForeignKey("IdTeams")]
        public  Teams Team { get; set; }
        [ForeignKey("IdChassis")]
        public  Chassis Chassi { get; set; }
        [ForeignKey("IdEngines")]
        public  Engines Engine { get; set; }
        [ForeignKey("IdRacers")]
        public  Racers Racer { get; set; }
        [ForeignKey("IdTyres")]
        public  Tyres Tyre { get; set; }
    }
}
