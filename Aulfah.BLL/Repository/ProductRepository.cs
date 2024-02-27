using Aulfah.BLL.Interfaces;
using Aulfah.DataContex;
using Aulfah.Models;

namespace Aulfah.DAL.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDBContext _context;

        public ProductRepository(ApplicationDBContext context): base(context)
        {
            _context = context;
        }

      
    }
}