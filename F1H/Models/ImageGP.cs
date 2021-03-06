﻿using System.ComponentModel.DataAnnotations;

namespace F1H.Models
{
    public class ImageGP
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Size { get; set; }
    }
}
