using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
          return  _context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            return _context.Orders.OrderByDescending(x=>x.OrderID).Select(y=>y.TotalPrice).FirstOrDefault();
        }

        public decimal TodayTotalPrice()
        {
            throw new NotImplementedException();
        }

        public int TotalOrderCount()
        {
            return _context.Orders.Count();
        }
    }
}
