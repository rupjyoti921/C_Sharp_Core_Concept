using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            HttpContext.Session.SetString("LoginKey", "pass123");
            return View();
        }

        public IActionResult About()
        {
            if (HttpContext.Session.GetString("LoginKey") != null)
            {
                ViewBag.Data = HttpContext.Session.GetString("LoginKey").ToString();
                ViewBag.id = HttpContext.Session.Id;
            }
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("LoginKey") != null)
            {
                HttpContext.Session.Remove("LoginKey");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
