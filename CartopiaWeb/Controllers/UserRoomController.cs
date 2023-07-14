using CartopiaWeb.Interfaces;
using CartopiaWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CartopiaWeb.Controllers
{
    public class UserRoomController : Controller
    {
        private readonly ICarsReceiver _carsReceiver;
        private readonly ICarEditor _carEditor;

        public UserRoomController(ICarsReceiver carsReceiver, ICarEditor carEditor)
        {
            _carsReceiver = carsReceiver;
            _carEditor = carEditor;
        }

        public IActionResult Index()
        {
            var viewModel = new CarListViewModel(_carsReceiver);
            return View(viewModel);
        }

        public IActionResult Remove(string id) 
        {
            _carEditor.Delete(id);

            return RedirectToAction("Index", "Home");
        }
    }
}
