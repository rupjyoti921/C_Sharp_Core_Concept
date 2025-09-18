using System.Diagnostics;
using EFPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDBContext stuDbContext;

        public HomeController(StudentDBContext sdbc)
        {
            stuDbContext = sdbc;
        }

        public IActionResult Display()
        {
            return View(stuDbContext.Students.ToList());
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
    }
}
