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
    public class FeatureService : GenericService<Feature>, IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;

        public FeatureService(IGenericRepository<Feature> repository, IFeatureRepository featureRepository) : base(repository)
        {
            _featureRepository = featureRepository;
        }
    }
}
