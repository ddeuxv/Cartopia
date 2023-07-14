using CartopiaWeb.Interfaces;
using CartopiaWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CartopiaWeb.Controllers
{
    public class UserRoomController : Controller
    {
        private readonly ICarsReceiver _carsReceiver;
        private readonly ICarRemover _carRemover;

        public UserRoomController(ICarsReceiver carsReceiver, ICarRemover carRemover)
        {
            _carsReceiver = carsReceiver;
            _carRemover = carRemover;
        }

        public IActionResult Index()
        {
            var viewModel = new CarListViewModel(_carsReceiver);
            return View(viewModel);
        }

        public IActionResult Delete(string id) 
        {
            _carRemover.Remover(id);

            return RedirectToAction("Index", "Home");
        }
    }
}
