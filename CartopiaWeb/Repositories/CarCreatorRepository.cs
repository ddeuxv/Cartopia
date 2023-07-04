using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;

namespace CartopiaWeb.Repositories
{
    public class CarCreatorRepository : ICarCreator
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
                Photo = photoInBytes,
                Description = car.Description,
            };

            return newCar;
        }
    }
}
