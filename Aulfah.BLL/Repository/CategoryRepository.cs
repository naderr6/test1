using Aulfah.BLL.Interfaces;
using Aulfah.DAL.Model;
using Aulfah.DAL.Repositories;
using Aulfah.DataContex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulfah.BLL.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext _dBContext;
        public CategoryRepository(ApplicationDBContext dBContext):base(dBContext)
        {
            _dBContext = dBContext;
        }
    }
}
