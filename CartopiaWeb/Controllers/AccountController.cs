using CartopiaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CartopiaWeb.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegistration userModel)
        {
            return View();
        }
    }
}
