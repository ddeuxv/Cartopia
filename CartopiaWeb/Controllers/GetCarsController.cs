using CartopiaWeb.Interfaces;
using CartopiaWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CartopiaWeb.Controllers
{
    public class GetCarsController : Controller
    {
        private readonly ICarsReceiver _carsReceiver;

        public GetCarsController(ICarsReceiver carsReceiver)
        {
            _carsReceiver = carsReceiver;
        }

        public IActionResult CarReceiver()
        {
            var viewModel = new CarListViewModel(_carsReceiver);
            return View(viewModel);
        }
    }
}
