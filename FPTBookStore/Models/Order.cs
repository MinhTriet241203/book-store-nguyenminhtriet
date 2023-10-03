using System.ComponentModel.DataAnnotations;

namespace FPTBookStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser? User { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public string? OrderStatus { get; set; }
        public DateTime CreateDate = DateTime.Now;
        public OrderDetails? OrderDetails { get; set; }
    }
}
