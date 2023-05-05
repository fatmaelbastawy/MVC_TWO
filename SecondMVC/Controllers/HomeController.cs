using Microsoft.AspNetCore.Mvc;

namespace MVC_Lab2.Controllers
{
    public class HomeController : Controller
    {
        //Action//
        public IActionResult Index()
        {
            return View("Index");
        }

        [ActionName("About")]
        public IActionResult About()
        {
            return View("About");
        }

       
    }
  
}
