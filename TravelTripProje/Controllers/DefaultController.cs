using Microsoft.AspNetCore.Mvc;

namespace TravelTripProje.Controllers
{
    
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
   
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
        //public PartialViewResult Partial3()
        //{
        //    var deger = c.blogs
        //    return PartialView();
        //}
    }
}
