using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("Books/Index Books Controller");
        }
        public IActionResult New()
        {
            return Content("Books/New Books");
        }
        [Route("/books/best-sellers")]
        [Route("/books/best")]
        public IActionResult Best()
        {
            return Content("Books/Best Sellers");
        }
    }
}