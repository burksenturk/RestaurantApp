using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Core.Services
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TRemove(T entity);
        void TUpdate(T entity);
        T TGetById(int id);
        List<T> TGetListAll();
    }
}
