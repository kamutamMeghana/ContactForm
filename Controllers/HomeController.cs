using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContactForm.Models;

namespace ContactForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        // this is rebase testing 1

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        // this is rebase testing 1
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
