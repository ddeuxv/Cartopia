using CartopiaWeb.Models;

namespace CartopiaWeb.Interfaces
{
    public interface ICarCreator
    {
        CarInfo CreateCar(CarInfo car, byte[] photoInBytes);
    }
}
