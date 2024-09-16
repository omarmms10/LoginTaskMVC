using Day6Demo.Models;
using Day6Demo.ViewModels;
using Microsoft.AspNetCore.Mvc;
 

public class AccountController : Controller
{
    private readonly Day6MvcdbContext _context;

    public AccountController()
    {
        _context = new Day6MvcdbContext(); 
    }

    // GET: Account/Login
    public ActionResult Login()
    {

        return View();
    }

    // POST: Account/Login
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == model.Username && u.Password == model.Password);

            if (user != null)
            {
                // Authentication successful
                return RedirectToAction("Index", "Home"); // Redirect to Index action of HomeController
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password.");
            }
        }

        return View(model);
    }
}
