using AutoMapper;
using RestaurantApp.Core.DTOs.ProductDto;
using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Repositories;
using RestaurantApp.Core.Services;

namespace RestaurantApp.Service.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IProductRepository productRepository, IMapper mapper) : base(repository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public List<ResultProductWithCategory> TGetProductsWithCategories()
        {
            var product = _productRepository.GetProductsWithCategories();
            var productsDto = _mapper.Map<List<ResultProductWithCategory>>(product);
            return productsDto;
        }
    }
}
