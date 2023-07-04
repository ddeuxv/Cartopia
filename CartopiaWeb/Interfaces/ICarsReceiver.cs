using CartopiaWeb.Models.DTOs;

namespace CartopiaWeb.Interfaces
{
    public interface ICarsReceiver
    {
        IEnumerable<CarDTO> GetCarsFromStorage(); 
    }
}
