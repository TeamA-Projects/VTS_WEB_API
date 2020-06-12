using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using VTS.Models;

namespace VTS.IRepository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> getAllCategoriesAsync();
    }
}
