﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1H.Models
{
    public class Tracks
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdCountry { get; set; }
        [Required]
        public int IdImagesGp { get; set; }
        [Required]
        public string NameEn { get; set; }
        [Required]
        public string NameRus { get; set; }

        [ForeignKey("IdCountry")]
        public  Country Countr { get; set; }
        [ForeignKey("IdImagesGp")]
        public ImagesGP Image { get; set; }
    }
}
