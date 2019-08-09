using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Repositories;
using System;
using System.Collections.Generic;

namespace LuizalabsWishesManager.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }

        //public void Delete(int id)
        //{
        //    var product = _repository.GetById(id);
        //    _repository.Remove(product);
        //}

        //public IEnumerable<Product> List()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Product> List(int page, int pageSize)
        //{
        //    return _repository.List(page, pageSize);
        //}

        //public bool Save(Product product)
        //{
        //    return _repository.Save(product);
        //}

        //public bool Update(int id, Product user)
        //{
        //    return _repository.Update(id, user);
        //}
    }
}
