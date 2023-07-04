using CartopiaWeb.Interfaces;
using CartopiaWeb.Models.DTOs;

namespace CartopiaWeb.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<CarDTO> Cars
        {
            get { return GetCarList(); }
        }
        private readonly ICarsReceiver _carsReceiver;

        public CarListViewModel(ICarsReceiver carsReceiver)
        {
            _carsReceiver = carsReceiver;
        }



        public IEnumerable<CarDTO> GetCarList()
        {
            return _carsReceiver.GetCarsFromStorage();
        }
    }
}
