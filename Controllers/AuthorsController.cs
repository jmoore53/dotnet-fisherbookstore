using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Authors/Index Books Controller");
        }
        public IActionResult Featured()
        {
            return Content("Authors/Featured Authors");
        }
    }
}