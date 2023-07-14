using CartopiaWeb.Data;
using CartopiaWeb.Interfaces;

namespace CartopiaWeb.Repositories
{
    public class CarRemoverRepository : ICarRemover
    {
        private readonly CartopiaDbContext _context;

        public CarRemoverRepository(CartopiaDbContext context)
        {
            _context = context;
        }

        public void Remover(string id)
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
