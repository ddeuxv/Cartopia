using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;

namespace CartopiaWeb.Repositories
{
    public class CarRepository : ICarCreator
    {
        public CarInfo CreateCar(CarInfo car, byte[] photoInBytes)
        {
            CarInfo newCar = new()
            {
                TypeOfBrand = car.TypeOfBrand,
                Model = car.Model,
                Region = car.Region,
                Year = car.Year,
                EngineType  = car.EngineType,
                Price = car.Price,
                Bodyshell = car.Bodyshell,
                PhoneNumber = car.PhoneNumber,
                PhotoBinary = photoInBytes,
                Description = car.Description,
            };

            return newCar;
        }
    }
}
