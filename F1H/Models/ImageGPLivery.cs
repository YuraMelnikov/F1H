﻿using System.ComponentModel.DataAnnotations;

namespace F1H.Models
{
    public class ImageGPLivery
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Link { get; set; }
    }
}