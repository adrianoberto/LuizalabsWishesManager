using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LuizalabsWishesManager.Domains.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, int page, int pageSize);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(int page, int pageSize);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Dispose();
    }
}
