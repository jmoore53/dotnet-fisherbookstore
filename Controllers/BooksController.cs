using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View();
        }
        [Route("/books/best-sellers")]
        [Route("/books/best")]
        public IActionResult Best()
        {
            return View();
        }
    }
}