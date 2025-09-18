using Microsoft.AspNetCore.Mvc;

namespace ConvRoutingEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Details(int id)
        {
            return id;
        }
    }
}
