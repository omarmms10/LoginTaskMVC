using Microsoft.AspNetCore.Mvc;

namespace Day6Demo.Controllers
{
    public class Demos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SetTempData()
        {
            if (!TempData.ContainsKey("Name") || !TempData.ContainsKey("Age"))
            {
                //TempData.Peek("Name", "Smart Software");
                TempData["Age"] = 40; //Set
            }
            return Content("Save TempData ........");
        }
        public IActionResult getTempData()
        {
            string name = "No Data";
            int age = 0;
            if (TempData.ContainsKey("Name") || TempData.ContainsKey("Age"))
            {
                 name = TempData["Name"].ToString();
                 age = (int)TempData["Age"];
            }
            

            return Content($"TempData : name {name} age {age}...");
        }
        public IActionResult getTempDataSecond()
        {
            string name = TempData["Name"].ToString();
            int age = (int)TempData["Age"];

            return Content($"TempData : name {name} age {age}...");
        }
    }
}
