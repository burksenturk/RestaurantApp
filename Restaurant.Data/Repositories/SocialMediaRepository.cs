using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Data.Repositories
{
    public class SocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaRepository
    {
        public SocialMediaRepository(AppDbContext context) : base(context)
        {
        }
    }
}
