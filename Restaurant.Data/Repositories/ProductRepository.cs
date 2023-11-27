using Microsoft.EntityFrameworkCore;
using RestaurantApp.Core.Entities;
using RestaurantApp.Core.Repositories;
using RestaurantApp.Data;
namespace RestaurantApp.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {

            return _context.Products.Include(p => p.Category).ToList();
        }
    } 
}
