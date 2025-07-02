using Microsoft.AspNetCore.Mvc;

namespace MenuCraftWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string id = null)
        {
            return View();
        }
    }
}
