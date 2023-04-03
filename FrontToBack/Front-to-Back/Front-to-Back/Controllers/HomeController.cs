using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Front_to_Back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}