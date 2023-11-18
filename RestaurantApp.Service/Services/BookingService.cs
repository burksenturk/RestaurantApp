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
    public class BookingService : GenericService<Booking>, IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IGenericRepository<Booking> repository, IBookingRepository bookingRepository) : base(repository)
        {
            _bookingRepository = bookingRepository;
        }
    }
}
