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
    public class ContactService : GenericService<Contact>, IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IGenericRepository<Contact> repository, IContactRepository contactRepository) : base(repository)
        {
            _contactRepository = contactRepository;
        }
    }
}
