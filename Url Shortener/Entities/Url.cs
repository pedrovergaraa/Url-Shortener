
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Url_Shortener.Models;

namespace Url_Shortener.Entities
{
    public class URL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Url { get; set; } = string.Empty;
       
        public string? ShortUrl { get; set; }
        [Required]
        [StringLength(500)]
        public int ContVisitas { get; set; }
        [Required]
        public CategoriaEnum Categoria { get; set; }
    }
}
