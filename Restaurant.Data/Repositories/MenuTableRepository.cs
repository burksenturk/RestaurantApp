using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repositories
{
    public class MenuTableRepository : GenericRepository<MenuTable>, IMenuTableRepository
    {
        public MenuTableRepository(AppDbContext context) : base(context)
        {
        }

        public int MenuTableCount()
        {
            return _context.MenuTables.Count();
        }
    }
}
