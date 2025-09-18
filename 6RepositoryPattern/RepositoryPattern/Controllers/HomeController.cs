using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.Repository;
namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DataClass _studentData=null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentData = new DataClass();
        }

        public List<Student> GetAll()
        {
            return _studentData.GetAll();
        }

        public Student ById(int id)
        {
            return _studentData.GetById(id);
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
