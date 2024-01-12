using _3_haftanin_odevi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _3_haftanin_odevi.Controllers
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
        public IActionResult Property()
        {
            return View();
        }

    }
}
