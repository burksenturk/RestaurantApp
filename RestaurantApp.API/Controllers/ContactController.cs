using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Core.DTOs.ContactDto;
using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Services;

namespace RestaurantApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var contacts = _contactService.TGetListAll();
            var contactsDtos = _mapper.Map<List<ResultContactDto>>(contacts);
            return Ok(contactsDtos);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription = createContactDto.FooterDescription,
                FooterTitle = createContactDto.FooterTitle,
                Location = createContactDto.Location,
                Mail=createContactDto.Mail,
                OpenDays=createContactDto.OpenDays,
                OpenDaysDescription=createContactDto.OpenDaysDescription,
                OpenHours=createContactDto.OpenHours,
                Phone=createContactDto.Phone
            });
            return Ok("İletişim Bİlgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TRemove(value);
            return Ok("İletişim Bİlgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                ContactID=updateContactDto.ContactID,
                FooterDescription = updateContactDto.FooterDescription,
                FooterTitle = updateContactDto.FooterTitle,
                Location = updateContactDto.Location,
                Mail = updateContactDto.Mail,
                OpenDays = updateContactDto.OpenDays,
                OpenDaysDescription = updateContactDto.OpenDaysDescription,
                OpenHours = updateContactDto.OpenHours,
                Phone = updateContactDto.Phone
            });
            return Ok("İletişim Bİlgisi Güncellendi");
        }
    }
}
