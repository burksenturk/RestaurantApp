using RestaurantApp.Core.Repositories;
using RestaurantApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Service.Services
{
    public class MoneyCaseService : IMoneyCaseService
    {
        private readonly IMoneyCaseRepository _moneyCaseRepository;

        public MoneyCaseService(IMoneyCaseRepository moneyCaseRepository)
        {
            _moneyCaseRepository = moneyCaseRepository;
        }

        public decimal TTotalMoneyCaseAmount()
        {
            return _moneyCaseRepository.TotalMoneyCaseAmount();
        }
    }
}
