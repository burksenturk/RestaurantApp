using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repositories
{
    public class MoneyCaseRepository : GenericRepository<MoneyCase>, IMoneyCaseRepository
    {
        public MoneyCaseRepository(AppDbContext context) : base(context)
        {
        }
        public decimal TotalMoneyCaseAmount()
        {
            return _context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}
