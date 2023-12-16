using Microsoft.Extensions.DependencyInjection;
using RestaurantApp.Core.Repositories;
using RestaurantApp.Core.Services;
using RestaurantApp.Data.Repositories;
using RestaurantApp.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Service.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IAboutRepository,AboutRepository>();

            //services.AddScoped<IBasketService, BasketService>();
            //services.AddScoped<IBasketRepository, BasketRepository>();

            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IBookingRepository, BookingRepository>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IContactRepository, ContactRepository>();

            services.AddScoped<IDiscountService, DiscountService>();
            services.AddScoped<IDiscountRepository, DiscountRepository>();

            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<ISocialMediaService, SocialMediaService>();
            services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();

            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISliderRepository, SliderRepository>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();

            services.AddScoped<IMoneyCaseService, MoneyCaseService>();
            services.AddScoped<IMoneyCaseRepository, MoneyCaseRepository>();

            services.AddScoped<IMenuTableService, MenuTableService>();
            services.AddScoped<IMenuTableRepository, MenuTableRepository>();
        }
    }
}
