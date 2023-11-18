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
    public class DiscountService : GenericService<Discount>, IDiscountService
    {
        private readonly IDiscountRepository _discountRepository;

        public DiscountService(IGenericRepository<Discount> repository, IDiscountRepository discountRepository) : base(repository)
        {
            _discountRepository = discountRepository;
        }
    }
}
