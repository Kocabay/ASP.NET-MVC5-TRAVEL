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
        public IActionResult s()
        {
            return View();
        }
    }
}
