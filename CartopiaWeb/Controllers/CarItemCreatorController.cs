using CartopiaWeb.Data;
using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CartopiaWeb.Controllers
{
    public class CarItemCreatorController : Controller
    {
        private readonly IPhotoConverter _photoConverter;
        private readonly ICarCreator _carRepository;
        private readonly CartopiaDbContext _context;
        private CarInfo? newCar { get; set; } = null;

        public CarItemCreatorController(CartopiaDbContext context, IPhotoConverter converter, ICarCreator carCreator)
        {
            _context = context;
            _photoConverter = converter;
            _carRepository = carCreator;
        }


        public IActionResult SalePage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendItems(CarInfo carInfo, IFormFile photo)
        {
            var photoInBytes = _photoConverter.GetPhotoBytes(photo);
            newCar = _carRepository.CreateCar(carInfo, photoInBytes);
            _context.Cars.Add(newCar);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}
