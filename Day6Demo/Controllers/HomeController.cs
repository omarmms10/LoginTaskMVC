using Day6Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace Day6Demo.Controllers
{

    public class HomeController : Controller
    {
        private readonly Day6MvcdbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,Day6MvcdbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        public IActionResult showList()
        {
            //var departList = _dbContext.Departments.ToList();
            //return View(departList);
            ViewBag.departmentID = new SelectList(_dbContext.Departments, "DepartmentId", "DepartmentName");
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ShowWebsite()
        {
            return View();
        }
    }
}
