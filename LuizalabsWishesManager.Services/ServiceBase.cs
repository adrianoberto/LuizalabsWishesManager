using LuizalabsWishesManager.Data.Repositories;
using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Repositories;
using LuizalabsWishesManager.Domains.Services;
using System;
using System.Collections.Generic;

namespace LuizalabsWishesManager.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository) => _repository = repository;


        public void Delete(int id)
        {
            var entity = _repository.GetById(id);
            _repository.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<TEntity> GetAll(int page, int pageSize)
        {
            return _repository.GetAll(page, pageSize);
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
