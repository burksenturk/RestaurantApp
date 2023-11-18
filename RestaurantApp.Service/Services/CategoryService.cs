using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Repositories;
using RestaurantApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Service.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IGenericRepository<Category> repository, ICategoryRepository categoryRepository) : base(repository)
        {
            _categoryRepository = categoryRepository;
        }
    }
}
