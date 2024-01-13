using Microsoft.AspNetCore.Mvc;

namespace Hurry_app_Website.Controllers
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
       public IActionResult GoToHome()
        {
           return RedirectToAction("Index", "Home");
        }
       
    }
}
