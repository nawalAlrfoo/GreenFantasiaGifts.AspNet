using System.ComponentModel.DataAnnotations;

namespace GreenFantasiaGifts011.Models 
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = "Customer"; 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}