using Microsoft.AspNetCore.Mvc;

namespace Data_Access.Controllers
{
    public class View_Data_Example : Controller
    {
        public IActionResult Index()
        {

            String name = "Akshay";
            int age= 25;
            String city = "Surat";

            ViewData["Name"] = name;
            ViewData["Age"] = age;
            ViewData["City"] = city;



            List<string> Languages = new List<string> { "SQL", "JAVA", ".Net", "Flutter" };
            ViewData["Lang"] = Languages;




            return View();
        }
    }
}
