using RestaurantApp.Core.Repositories;
using RestaurantApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public void TAdd(T entity)
        {
            _repository.Add(entity);
        }

        public T TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<T> TGetListAll()
        {
            return _repository.GetListAll();
        }

        public void TRemove(T entity)
        {
            _repository.Remove(entity);
        }

        public void TUpdate(T entity)
        {
            _repository.Update(entity);

        }
    }
}
