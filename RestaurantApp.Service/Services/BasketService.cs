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
    public class BasketService : GenericService<Basket>, IBasketService
    {
        private readonly IBasketRepository _basketRepository;

        public BasketService(IGenericRepository<Basket> repository, IBasketRepository basketRepository) : base(repository)
        {
            _basketRepository = basketRepository;
        }
    }
}
