using Microsoft.AspNetCore.Mvc;
using Practice.Models;
using Practice.ViewModels.Home;
using Practice.ViewModels.Product;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["name"] = "Chinara";
            //TempData["surname"] = "Ibadova";
            //ViewBag.address = "Lokbatan";
            //ViewBag.nums = new List<int>() { 1, 2, 3, 4, 5 };
            ////return RedirectToAction("Detail");
            //string firstName = "Konul";
            //return View((object)firstName); 
            Student student1 = new()
            {
                Id = 1,
                Name = "Elekber",
                Age = 21
            };
            Student student2 = new()
            {
                Id = 2,
                Name = "Shaiq",
                Age = 25
            };
            List<Student> students = new List<Student> { student1, student2 };

            Product product = new()
            {
                Id = 1,
                Name = "Samsung",
                Price = 5000,
                Description = "Desc",
                Count = 10
            };
            ProductVM productVM = new()
            {
                Name = product.Name,
                Price = product.Price
            };

            HomeVM model = new()
            {
                Student = students,
                Product = productVM
            };
                
            return View(model);
        }
      
        //public IActionResult Detail()
        //{
        //    return View();
        //}
    }
}
