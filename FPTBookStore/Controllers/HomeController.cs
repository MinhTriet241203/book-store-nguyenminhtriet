using BookstoreEmailService.Models;
using BookstoreEmailService.Services;
using FPTBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FPTBookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IEmailService _emailService;
        public HomeController(ILogger<HomeController> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }
		public IActionResult HomePage()
		{
			return View();
		}

		public IActionResult Shop()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //demo only -- TODO: remove this
        [HttpGet]
        public IActionResult SendEmail()
        {
            var message = new MailMessage(new string[] { "mrshine4k@gmail.com", "trietnmgcs210026@fpt.edu.vn" },
                "Email từ app thư viện",
                "Gửi được email thư viện rồi nè :O https://i.imgflip.com/5c15oj.png?a467760");
            _emailService.SendEmail(message);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}