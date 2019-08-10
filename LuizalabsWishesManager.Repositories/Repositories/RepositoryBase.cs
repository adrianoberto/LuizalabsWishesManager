using LuizalabsWishesManager.Domains.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LuizalabsWishesManager.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly LuizalabsWishesManagerContext _context;

        public RepositoryBase()
        {
            var options = new DbContextOptionsBuilder<LuizalabsWishesManagerContext>()
               .UseInMemoryDatabase(databaseName: "luizalabs")
               .Options;

            _context = new LuizalabsWishesManagerContext(options);
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetAll(int page, int pageSize)
        {
            return _context.Set<TEntity>()
                .Skip(pageSize * (page - 1))
                .Take(pageSize);                
        }
        
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>()                
                .Where(predicate);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, int page, int pageSize)
        {
            return _context.Set<TEntity>()
                .Where(predicate)
                .Skip(pageSize * (page - 1))
                .Take(pageSize);
        }

        public void Update(TEntity entity)
        {   
            _context.Entry(entity).State = EntityState.Modified;            
            _context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
           
        }
    }
}
