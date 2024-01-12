using _3_haftanin_odevi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _3_haftanin_odevi.Controllers
{
    public class PropertyController : Controller
    {
        private readonly ILogger<PropertyController> _logger;

        public PropertyController(ILogger<PropertyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    
    }
}
