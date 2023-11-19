using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repositories
{
    public class SliderRepository : GenericRepository<Slider> , ISliderRepository
    {
        public SliderRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
