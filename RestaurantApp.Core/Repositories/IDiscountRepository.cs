using RestaurantApp.Core.Entities;


namespace RestaurantApp.Core.Repositories
{
    public interface IDiscountRepository : IGenericRepository<Discount>
    {
        void ChangeStatusToTrue(int id);
        void ChangeStatusToFalse(int id);
        List<Discount> GetListByStatusTrue();
    }
}
