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
    public class MenuTableService : GenericService<MenuTable> , IMenuTableService
    {
        private readonly IMenuTableRepository _menuTableRepository;

        public MenuTableService(IGenericRepository<MenuTable> repository, IMenuTableRepository menuTableRepository) : base(repository)
        {
            _menuTableRepository = menuTableRepository;
        }

        public int TMenuTableCount()
        {
            return _menuTableRepository.MenuTableCount();
        }
    }
}
