using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
