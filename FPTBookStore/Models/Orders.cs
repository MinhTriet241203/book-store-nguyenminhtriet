using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPTBookStore.Models
{
    public class Order
    {
        [Required]
        public int OrderId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        [Required]
        [ForeignKey("Book")]
        [Display(Name = "Book")]
        public int BookId { get; set; }
        public virtual Book? Book { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? Status { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public decimal? Total { get; set; }
    }
}
