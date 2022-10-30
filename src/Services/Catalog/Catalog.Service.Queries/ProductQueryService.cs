

using Catalog.Persistance.Database;

namespace Catalog.Service.Queries
{
    public class ProductQueryService
    { 
        private readonly ApplicationDbContext _context;
        public ProductQueryService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
