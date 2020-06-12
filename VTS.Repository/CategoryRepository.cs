using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using VTS.Models;
using VTS.IRepository;
using VTS.DataAccess;


namespace VTS.Repository
{
    public class CategoryRepository : ICategoryRepository
    {        
        public async Task<List<Category>> getAllCategoriesAsync()
        {
            List<Category> categories = new List<Category>();
            categories = await CategoryDB.getAllCategories();

            return categories;
        }
    }
}
