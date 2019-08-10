using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Repositories;

namespace LuizalabsWishesManager.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
