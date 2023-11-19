using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Core.DTOs.CategoryDto;
using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Services;

namespace RestaurantApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var categories = _categoryService.TGetListAll();
            var categoriesDtos = _mapper.Map<List<ResultCategoryDto>>(categories);
            //var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(categoriesDtos);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = true
            });
            return Ok("Kategori Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TRemove(value);
            return Ok("Kategori Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
                CategoryName = updateCategoryDto.CategoryName,
                CategoryID = updateCategoryDto.CategoryID,
                Status = updateCategoryDto.Status
            });
            return Ok("Kategori Güncellendi");
        }
    }
}
