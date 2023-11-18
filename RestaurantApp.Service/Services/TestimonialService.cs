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
    public class TestimonialService : GenericService<Testimonial>, ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialService(IGenericRepository<Testimonial> repository, ITestimonialRepository testimonialRepository) : base(repository)
        {
            _testimonialRepository = testimonialRepository;
        }
    }
}
