using RestaurantApp.Core.Entities;


namespace RestaurantApp.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetProductsWithCategories();
    }
}
