using Microsoft.AspNetCore.Mvc;

namespace Hurry_app_Website.Controllers
{
    public class PartyController : Controller
    {
        public IActionResult Party()
        {
            return View();
        }
        public IActionResult JoinParty()
        {
            return RedirectToAction("Party");
        }
    }
}
