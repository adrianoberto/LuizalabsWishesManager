using System;
using System.Collections.Generic;
using System.Text;

namespace LuizalabsWishesManager.Domains.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll(int page, int pageSize);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
