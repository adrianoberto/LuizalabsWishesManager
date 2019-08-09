using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Repositories;
using LuizalabsWishesManager.Domains.Services;

namespace LuizalabsWishesManager.Services
{
    public class WishService : ServiceBase<Wish>, IWishService
    {
        private readonly IWishRepository _repository;
       
        public WishService(IWishRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public void Delete(int userId, int productId)
        {
            var wish = 
                _repository.Get(x => x.UserId == userId && x.Products != null && x.Products.Any(y => y.Id == productId));

            if (wish is null) return;
            
            int qtd = wish.Products.RemoveAll(x => x.Id == productId);

            if (qtd > 0) _repository.Update(wish);
        }

        public Wish GetById(int wishId, int page, int pageSize) =>
            _repository.GetById(wishId);                
    }
}
