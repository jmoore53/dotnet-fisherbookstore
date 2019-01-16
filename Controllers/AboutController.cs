using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("About/Hello World");
        }
        public IActionResult History()
        {
            return Content("About/History Page");
        }
        public IActionResult Location()
        {
            return Content("About/Location Page");
        }
    }
}