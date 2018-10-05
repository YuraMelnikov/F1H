using System.ComponentModel.DataAnnotations;

namespace F1H.Models
{
    public class TypeFinish
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ShortName { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
