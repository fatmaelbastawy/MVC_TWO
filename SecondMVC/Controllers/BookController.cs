using Microsoft.AspNetCore.Mvc;
using SecondMVC.Models;

namespace SecondMVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Book()
        {
            LibraryContext db = new LibraryContext();
            var books = db.Books.ToList();
            return View("Book",books);
        }
    }
}
