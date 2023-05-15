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
        private readonly IEmailService _emailService;

        public HomeController(ILogger<HomeController> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult SendEMail()
        {
            var message = new MailMessage(new string[] { "mrshine4k@gmail.com" }, "subject", "Content: Emailing works");
            _emailService.SendEmail(message);
            return StatusCode(StatusCodes.Status200OK);
        }

    }
}