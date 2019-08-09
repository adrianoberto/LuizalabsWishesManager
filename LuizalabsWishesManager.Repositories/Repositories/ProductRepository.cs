using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LuizalabsWishesManager.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        //private readonly LuizalabsWishesManagerContext _context;
        //public ProductRepository(LuizalabsWishesManagerContext context) => _context = context;

        //public bool Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Product> List(int pageSize, int page)
        //{
        //    var _context = new LuizalabsWishesManagerContext();

        //    return _context.Products
        //        .ToList();

           
        //    //var sqlite_conn = new SqliteConnection("DataSource=:memory:");
        //    //sqlite_conn.Open();
        //    //return sqlite_conn
        //    //        .GetAll<Product>()
        //    //        .Where((user, index) => index >= page - 1)
        //    //        .Take(pageSize);

   

           
        //    ////using (SqlConnection connection = new SqlConnection(
        //    ////    _configuration.GetConnectionString("ExemplosDapper")))
        //    ////{
        //    ////    return connection
        //    ////        .GetAll<Product>()
        //    ////        .Where((user, index) => index >= page - 1)
        //    ////        .Take(pageSize);
        //    ////}
        //}

        //public IEnumerable<Product> List()
        //{
        //    return _context.Products.ToList();
        //}

        //public bool Save(Product product)
        //{
        //    #region code protected
        //    if (product == null) throw new NullReferenceException("user required");
        //    #endregion

        //    var _context = new LuizalabsWishesManagerContext();

            
        //    _context.Products.Add(product);
        //    _context.SaveChanges();

        //    return true;
        //}

        //public bool Update(int id, Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //private IEnumerable<Product> GetFakeProducts()
        //{
        //    return new List<Product>()
        //    {
        //        new Product { Id = 1, Name = "Produto 1" },
        //        new Product { Id = 2, Name = "Produto 2" },
        //        new Product { Id = 3, Name = "Produto 3" },
        //    };
        //}
    }
}
