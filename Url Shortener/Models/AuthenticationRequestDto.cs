using System.ComponentModel.DataAnnotations;

namespace Url_Shortener.Models
{
    public class AuthenticationRequestDto
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
