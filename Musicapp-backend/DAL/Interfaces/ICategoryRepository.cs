using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musicapp_backend.Models;

namespace Musicapp_backend.DAL.Interfaces
{
    public interface ICategoryRepository
    {
       public IEnumerable<Category> GetAllCategories();
    }
}
