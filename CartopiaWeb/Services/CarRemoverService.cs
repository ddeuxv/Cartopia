using CartopiaWeb.Data;
using CartopiaWeb.Interfaces;

namespace CartopiaWeb.Services
{
    public class CarRemoverService : ICarEditor
    {
        private readonly CartopiaDbContext _context;

        public CarRemoverService(CartopiaDbContext context)
        {
            _context = context;
        }

        public void Delete(string id)
        {
            var carToDelete = _context.Cars.FirstOrDefault(c => c.CreatedByUserId == id);
            if (carToDelete != null)
            {
                _context.Cars.Remove(carToDelete);
                _context.SaveChanges();
            }
        }
    }
}
