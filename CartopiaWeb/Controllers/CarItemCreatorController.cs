using CartopiaWeb.Data;
using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace CartopiaWeb.Controllers
{
    public class CarItemCreatorController : Controller
    {
        private readonly IPhotoConverter _photoConverter;
        private readonly ICarCreator _carRepository;
        private readonly CartopiaDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private CarInfo? newCar { get; set; } = null;


        public CarItemCreatorController(CartopiaDbContext context, 
                                                            IPhotoConverter converter, ICarCreator carCreator,
                                                            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _photoConverter = converter;
            _carRepository = carCreator;
            _userManager = userManager;
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
            newCar.CreatedByUserId = _userManager.GetUserId(User);
            _context.Cars.Add(newCar);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}
