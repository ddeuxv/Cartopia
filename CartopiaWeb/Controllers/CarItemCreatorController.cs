using Microsoft.AspNetCore.Mvc;

namespace CartopiaWeb.Controllers
{
    public class CarItemCreatorController : Controller
    {
        // implement car controller for sale items
        [HttpGet]
        public IActionResult SalePage()
        {
            return View();
        }
    }
}
