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
    public class SliderService : GenericService<Slider> , ISliderService
    {
        private readonly ISliderRepository _sliderRepository;

        public SliderService(IGenericRepository<Slider> repository, ISliderRepository sliderRepository) : base(repository)
        {
            _sliderRepository = sliderRepository;
        }
    }
}
