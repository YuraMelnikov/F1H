using System.ComponentModel.DataAnnotations;

namespace F1H.Models
{
    public class TypeDNQ
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
