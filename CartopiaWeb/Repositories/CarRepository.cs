using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;

namespace CartopiaWeb.Repositories
{
    public class CarRepository : ICarCreator
    {
        public void CreateCar(CarInfo car)
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
                PhotoBinary = car.PhotoBinary,
                Description = car.Description,
            }; 

        }
    }
}
