using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System;

namespace F1H.Models
{
    public class TeamName
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdTeams { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public string FullName { get; set; }

        [ForeignKey("IdTeams")]
        public Teams Team { get; set; }
    }
}
