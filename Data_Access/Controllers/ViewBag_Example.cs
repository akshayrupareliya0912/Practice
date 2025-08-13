using Microsoft.AspNetCore.Mvc;

namespace Data_Access.Controllers
{
    public class ViewBag_Example : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Name = "Akshay";   
            ViewBag.Age = 25;
            ViewBag.City = "Surat";

            ViewBag.Languages = new List<string> { "SQL", "JAVA", ".Net", "Flutter" };

            var products = new {ID=101, Name="Keyboard", Price=500  };
            ViewBag.Product = products; 

            return View();
        }
    }
}
