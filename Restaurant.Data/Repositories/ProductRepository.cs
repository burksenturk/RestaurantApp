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

        public decimal ProductAvgPriceByHamburger()
        {
            return _context.Products.Where(x => x.CategoryID == (_context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
        }

        public int ProductCount()
        {
           return _context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            return _context.Products.Where(x => x.CategoryID == (_context.Categories.Where(y => y.CategoryName == "İçecekler").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            return _context.Products.Where(x => x.CategoryID == (_context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            return _context.Products.Where(x => x.Price == (_context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            return _context.Products.Where(x => x.Price == (_context.Products.Min(y => y.Price))).Select(q => q.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            return _context.Products.Select(x => x.Price).Average();
        }

        public decimal ProductPriceBySteakBurger()
        {
            throw new NotImplementedException();
        }

        public decimal TotalPriceByDrinkCategory()
        {
            throw new NotImplementedException();
        }

        public decimal TotalPriceBySaladCategory()
        {
            throw new NotImplementedException();
        }
    } 
}
