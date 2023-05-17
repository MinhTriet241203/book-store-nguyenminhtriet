using System.ComponentModel.DataAnnotations;

namespace FPTBookStore.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ApplicationUser? User { get; set; }
        [Required]
        public ICollection<CartDetails>? CartDetails { get; set; }
    }
}
