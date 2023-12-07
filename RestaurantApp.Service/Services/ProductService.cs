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

        public string TProductNameByMaxPrice()
        {
            return _productRepository.ProductNameByMaxPrice();
        }

        public string TProductNameByMinPrice()
        {
            return _productRepository.ProductNameByMinPrice();
        }
        public int TProductCount()
        {
            return _productRepository.ProductCount();
        }

        public int TProductCountByCategoryNameDrink()
        {
            return _productRepository.ProductCountByCategoryNameDrink();
        }

        public int TProductCountByCategoryNameHamburger()
        {
            return _productRepository.ProductCountByCategoryNameHamburger();
        }

        public decimal TProductPriceAvg()
        {
            return _productRepository.ProductPriceAvg();
        }

        public void TUpdate(Product entity)
        {
            _productRepository.Update(entity);
        }

        public decimal TProductAvgPriceByHamburger()
        {
            return _productRepository.ProductAvgPriceByHamburger();
        }

        public decimal TProductPriceBySteakBurger()
        {
            return _productRepository.ProductPriceBySteakBurger();
        }

        public decimal TTotalPriceByDrinkCategory()
        {
            return _productRepository.TotalPriceByDrinkCategory();
        }

        public decimal TTotalPriceBySaladCategory()
        {
            return _productRepository.TotalPriceBySaladCategory();
        }
    }
}
