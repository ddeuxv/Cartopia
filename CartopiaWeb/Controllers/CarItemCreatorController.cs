using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CartopiaWeb.Controllers
{
    public class CarItemCreatorController : Controller
    {
        private readonly IPhotoConverter _photoConverter;
        private readonly ICarCreator _carRepository;


        public CarItemCreatorController(IPhotoConverter converter, ICarCreator carcreator)
        {
            _photoConverter = converter;
            _carRepository = carcreator;
        }

        [HttpPost]
        public IActionResult SendItems(CarInfo carInfo)
        {
            return View();
        }
    }
}
