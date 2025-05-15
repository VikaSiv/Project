using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class User
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string ContactInfo { get; set; } = string.Empty;

        [Required]
        public string Role { get; set; } = string.Empty;

        [Required]
        public string Login { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
        public ICollection<Project> Projects { get; set; }
    }

}
