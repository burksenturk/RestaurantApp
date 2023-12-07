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
    public class OrderDetailService : GenericService<OrderDetail>, IOrderDetailService
    {
        private readonly IOrderDetailRepository _aboutRepository;

        public OrderDetailService(IGenericRepository<OrderDetail> repository, IOrderDetailRepository aboutRepository) : base(repository)
        {
            _aboutRepository = aboutRepository;
        }
    }
}
