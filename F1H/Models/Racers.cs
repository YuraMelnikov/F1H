using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System;

namespace F1H.Models
{
    public class Racers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdCountry { get; set; }
        [Required]
        public DateTime Born { get; set; }
        [Required]
        public string BornIn { get; set; }
        [Required]
        public DateTime Dead { get; set; }
        [Required]
        public string DeadIn { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public int IndexPhoto { get; set; }
        [Required]
        public string TextData { get; set; }

        [ForeignKey("IdCountry")]
        public  Country Countr { get; set; }
        [ForeignKey("IndexPhoto")]
        public  ImagesGPRacers Image { get; set; }
    }
}
