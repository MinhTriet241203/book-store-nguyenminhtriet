using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FPTBookStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
    }
}
