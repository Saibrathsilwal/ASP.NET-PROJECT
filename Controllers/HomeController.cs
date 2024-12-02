using GSLLS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;

namespace GSLLS.Controllers
{
    [Authorize] // This attribute restricts access to the entire controller to authenticated users only
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous] // This allows unauthenticated users to access the home page
        public IActionResult Index()
        {
            return View();
        }

        // Privacy page requires authentication
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous] // Error page should be accessible to all users
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}