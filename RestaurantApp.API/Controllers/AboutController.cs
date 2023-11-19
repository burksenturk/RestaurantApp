using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Core.DTOs.AboutDto;
using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Services;

namespace RestaurantApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController (IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto) 
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl
            };
             _aboutService.TAdd(about);
            return Ok("Hakkında Kısmı Başarıyla EKlendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TRemove(value);
            return Ok("Silme işlmei başarı ile gerçekleşti.");
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutID = updateAboutDto.AboutID,
                ImageUrl = updateAboutDto.ImageUrl,
                Description = updateAboutDto.Description,
                Title = updateAboutDto.Title
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkımda Alanı Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }
    }
}
