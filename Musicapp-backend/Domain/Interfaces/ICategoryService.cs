using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musicapp_backend.Models;

namespace Musicapp_backend.Domain.Interfaces
{
    public interface ICategoryService
    {
        public IEnumerable<Category> GetAllCategories();
    }
}
