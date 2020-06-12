using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VTS.Models;
using VTS.IRepository;

namespace VTS.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
             
        private ICategoryRepository catRepo;

        public CategoryController(ICategoryRepository Repo)
        {
            catRepo = Repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return await  catRepo.getAllCategoriesAsync();
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<Category>> Get(int id)
        {
            return await catRepo.getAllCategoriesAsync();
        }
    }
}
