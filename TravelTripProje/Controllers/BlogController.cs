using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Models.Sınıflar;
namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            return View(bloglar);
        }
        BlogYorum by = new BlogYorum();
        public IActionResult BlogDetails(int id)
        {

            var blogbul = c.Blogs.Where(x=>x.ID==id).ToList();
            //by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            //by.Deger2 = c.Yorumlars.Where(x => x.ID == id).ToList();
            return View(blogbul);
        }
    }
}
