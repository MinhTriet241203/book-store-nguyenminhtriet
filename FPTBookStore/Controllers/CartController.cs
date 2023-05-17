using FPTBookStore.Data;
using FPTBookStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FPTBookStore.Controllers
{
    public class CartController : Controller
    {

        internal readonly ApplicationDbContext _context;
        internal readonly HttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartController(ApplicationDbContext context, HttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        private string GetUserId()
        {
            var user = _httpContextAccessor.HttpContext.User;
            return _userManager.GetUserId(user);
        }

        //public Cart GetCart(string userId)
        //{
        //    var cart = _context.Cart.FirstOrDefault(x => x.UserId == userId);
        //    return cart;
        //}

        //public void AddToCart(int bookID, int quantity)
        //{
        //    var userID = GetUserId();
        //    var cart = GetCart(userID, bookID);
        //}
    }
}
