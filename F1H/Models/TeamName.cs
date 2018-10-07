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
        public int IdTeam { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public string FullName { get; set; }

        [ForeignKey("IdTeam")]
        public Team Team { get; set; }
    }
}
