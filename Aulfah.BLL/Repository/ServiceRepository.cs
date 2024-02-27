using Aulfah.BLL.Interfaces;
using Aulfah.DataContex;
using Aulfah.Models;

namespace Aulfah.DAL.Repositories
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        private readonly ApplicationDBContext _context;

        public ServiceRepository(ApplicationDBContext context):base(context)
        {
            _context = context;
        }

     
    }
}