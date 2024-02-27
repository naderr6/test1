using Aulfah.BLL.Interfaces;
using Aulfah.DataContex;
using Aulfah.Models;

namespace Aulfah.DAL.Repositories
{
    public class ArtistRepository :GenericRepository<Artist>,IArtistRepository
    {
        private readonly ApplicationDBContext _context;

        public ArtistRepository(ApplicationDBContext context):base(context) 
        {
            _context = context;
        }

        
    }
}
