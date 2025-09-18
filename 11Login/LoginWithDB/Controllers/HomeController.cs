using System.Diagnostics;
using LoginWithDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginWithDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly CodeFirstDbContext _dbContext;

        public HomeController( CodeFirstDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserDetail user)
        {
            var userData = _dbContext.UserDetails.Where(id => id.Email == user.Email && id.Password==user.Password).FirstOrDefault();
            if(userData != null)
            {
                HttpContext.Session.SetString("UserEmail",userData.Email);
                return RedirectToAction("Dashboard");
            }
            else
            {
                TempData["msg"] = "Wrong Credentials!";
                return View();
            }
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserEmail") != null)
            {
                TempData["msg"] = "Login Success!";
                ViewBag.User = HttpContext.Session.GetString("UserEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserEmail") != null)
            {
                HttpContext.Session.Remove("UserEmail");
                TempData["logoutMsg"] = "Logout Success!";
                return RedirectToAction("Login");
            }
            else { 

                return RedirectToAction("Login");
            }
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
