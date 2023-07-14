using CartopiaWeb.Data;
using CartopiaWeb.Interfaces;
using CartopiaWeb.Models.DTOs;

namespace CartopiaWeb.Repositories
{
    public class CarsReceiverRepository : ICarsReceiver
    {

        private readonly CartopiaDbContext _context;


        public CarsReceiverRepository(CartopiaDbContext context)
        {
            _context = context;
        }


        public IEnumerable<CarDTO> GetCarsFromStorage()
        {
            var dbCars = _context.Cars.ToList();

            var carList = dbCars.Select(dbCar => new CarDTO
            {
                Name = dbCar.TypeOfBrand + " " + dbCar.Model,
                Region = dbCar.Region,
                Year = dbCar.Year,
                EngineType = dbCar.EngineType,
                Price = dbCar.Price,
                Bodyshell = dbCar.Bodyshell,
                PhoneNumber = dbCar.PhoneNumber,
                Photo = dbCar.Photo,
                CreatedById = dbCar.CreatedByUserId
            });

            return carList;
        }
    }
}
