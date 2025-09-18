using System.Diagnostics;
using LayoutView.Models;
using Microsoft.AspNetCore.Mvc;

namespace LayoutView.Controllers
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

        public IActionResult About()
        {
            ViewBag.Heading = "ViewBag Practice";
            ViewBag.Phone_No = "9101171333";
            ViewBag.Place= "Guwahati";
            ViewData["Pin"] = 781001;

            String[] Members = ["Rohan", "Niva", "Bikash", "Bahul"];
            ViewBag.Persons = Members;

            List<int> ages = [78, 65, 28, 24];
            ViewBag.ages = ages;
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Heading"] = "ViewData Practice";

            ViewData["Phone No"] = "9101171333";
            ViewData["Place"] = "Guwahati";
            ViewData["Pin"] = 781001;

            String[] Members = ["Rohan", "Niva", "Bikash", "Bahul"];
            ViewData["Persons"] = Members;

            List<int> ages = [78, 65, 28, 24];
            ViewData["ages"] = ages;
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
    }
}
