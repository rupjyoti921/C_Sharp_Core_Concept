using Microsoft.AspNetCore.Mvc;

namespace AttribRouting.Controllers
{
    //[Route("/Home")]  // we can use route in controller also, so that we don't need to write Home again and again above the Action method
    public class HomeNohoiController : Controller
    {
        [Route("/")]
        [Route("/Home")]
        [Route("/Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("/")]
        //[Route("/Home")]
        //[Route("/Home/Index")]  // if we use Route it will based on the route and redirect.
        //public IActionResult Faltu()  // If we use Route, It doesn't matter what Controller name and Action Method Name
        //{
        //    return View("~/Views/Home/Index.cshtml");
        //}


        [Route("/About")]
        [Route("/Home/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/Details/{id?}")]
        [Route("/Home/Detiails/{id?}")]
        //public int Details(int id)
        //{
        //    return id;
        //}
        public int Details(int? id)
        {
            return id ?? 400;   //if null return 400
        }

    }
}
