using System.Collections.Generic;
using System.Linq;
using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Repositories;
using LuizalabsWishesManager.Domains.Services;

namespace LuizalabsWishesManager.Services
{
    public class WishService : ServiceBase<Wish>, IWishService
    {
        private readonly IWishRepository _wishRepository;
        private readonly IWishProductRepository _wishProductRepository;
        private readonly IProductRepository _productRepository;

        public WishService(IWishRepository wishRepository, IWishProductRepository wishProductRepository, 
            IProductRepository productRepository) : base(wishRepository)
        {
            _wishRepository = wishRepository;
            _wishProductRepository = wishProductRepository;
            _productRepository = productRepository;
        }

        public void Add(int userId, List<WishProduct> products)
        {
            var wish = Add(userId);
            AddProduct(wish, products);
        }

        public void Delete(int userId, int productId)
        {
            var wish = _wishRepository.GetAll(x => x.UserId == userId)
                                      .FirstOrDefault();

            if (wish is null) return;

            var product = _wishProductRepository
                .GetAll(x => x.IdWish == wish.Id && x.IdProduct == productId)
                .FirstOrDefault();

            if (product == null) return;

            _wishProductRepository.Remove(product);
        }

        public Wish GetById(int wishId, int page, int pageSize) =>
            _wishRepository.GetById(wishId);
        

        private Wish Add(int userId)
        {
            var wish = _wishRepository.GetAll(x => x.UserId == userId).SingleOrDefault();

            if (wish is null)
            {
                wish = new Wish { UserId = userId };
                _wishRepository.Add(wish);
            }

            return wish;
        }

        private void AddProduct(Wish wish, List<WishProduct> products)
        {
            var wishProducts = _wishProductRepository.GetAll(x => x.IdWish == wish.Id).ToList();

            if (wishProducts is null) wishProducts = new List<WishProduct>();

            products.RemoveAll(p => wishProducts.Exists(wp => wp.IdProduct == p.IdProduct));

            products.ForEach(p => {
                p.IdWish = wish.Id;
                _wishProductRepository.Add(p);                
            });
        }

        public IEnumerable<Product> GetAll(int userId, int page, int pageSize)
        {
            var wish = _wishRepository.GetAll(x => x.UserId == userId).FirstOrDefault();

            if (wish is null) return null;

            var wishProducts = _wishProductRepository.GetAll(x => x.IdWish == wish.UserId, page, pageSize);

            if (wishProducts is null || !wishProducts.Any()) return null;

            var products = new List<Product>();

            wishProducts.ToList().ForEach(x=> {
                var product = _productRepository.GetById(x.IdProduct);

                if (product is null) product = new Product { IdProduct = x.IdProduct, Name = "Não Localizado" };

                products.Add(product);
            });

            return products;
        }
    }
}
