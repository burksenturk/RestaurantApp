using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repositories
{
    public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
    {
        public DiscountRepository(AppDbContext context) : base(context)
        {
        }

        public void ChangeStatusToFalse(int id)
        {
            var value = _context.Discounts.Find(id);
            value.Status = false;
            _context.SaveChanges();
        }

        public void ChangeStatusToTrue(int id)
        {
            var value = _context.Discounts.Find(id);
            value.Status = true;
            _context.SaveChanges();
        }

        public List<Discount> GetListByStatusTrue()
        {
            var value = _context.Discounts.Where(x => x.Status == true).ToList();
            return value;
        }
    }
}
