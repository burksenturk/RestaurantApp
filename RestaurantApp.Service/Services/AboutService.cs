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
    public class AboutService : GenericService<About>, IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutService(IGenericRepository<About> repository, IAboutRepository aboutRepository) : base(repository)
        {
            _aboutRepository = aboutRepository;
        }
    }
}
