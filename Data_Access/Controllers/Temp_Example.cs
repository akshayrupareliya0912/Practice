using Microsoft.AspNetCore.Mvc;

namespace Data_Access.Controllers
{
    public class Temp_Example : Controller
    {
        public IActionResult Index()
        {
            TempData["name"] = "Akshay Rupareliya";
            return View();
        }
        public IActionResult TEMP1()
        {
            var td = TempData["name"];
            return View();
        }
        public IActionResult TEMP2()
        {
            var tdata = TempData["name"];
            return View();
        }
    }
}
