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
    public class SocialMediaService : GenericService<SocialMedia>, ISocialMediaService
    {
        private readonly ISocialMediaRepository _socialMediaRepository;

        public SocialMediaService(IGenericRepository<SocialMedia> repository, ISocialMediaRepository socialMediaRepository) : base(repository)
        {
            _socialMediaRepository = socialMediaRepository;
        }
    }
}
