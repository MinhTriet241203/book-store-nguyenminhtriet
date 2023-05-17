namespace FPTBookStore.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<CartDetails> CartDetails { get; set; }
    }
}
