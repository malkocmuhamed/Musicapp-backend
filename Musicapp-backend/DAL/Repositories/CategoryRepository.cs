using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Musicapp_backend.DAL.Interfaces;
using Musicapp_backend.Models;

namespace Musicapp_backend.DAL.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        musicappDBContext _context;

        public CategoryRepository(musicappDBContext context)
        {
            this._context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

    }
}
