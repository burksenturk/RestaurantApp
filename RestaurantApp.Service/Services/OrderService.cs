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
    public class OrderService : GenericService<Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IGenericRepository<Order> repository, IOrderRepository orderRepository) : base(repository)
        {
            _orderRepository = orderRepository;
        }

        public int TActiveOrderCount()
        {
          return  _orderRepository.ActiveOrderCount();
        }

        public decimal TLastOrderPrice()
        {
            return _orderRepository.LastOrderPrice();
        }

        public decimal TTodayTotalPrice()
        {
            return _orderRepository.TodayTotalPrice();
        }

        public int TTotalOrderCount()
        {
            return _orderRepository.TotalOrderCount();
        }
    }
}
