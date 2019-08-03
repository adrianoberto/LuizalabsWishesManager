using System.Collections.Generic;
using System.Linq;

namespace LuizalabsWishesManager.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public IEnumerable<Product> Get()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Produto 1" },
                new Product { Id = 1, Name = "Produto 2" },
                new Product { Id = 1, Name = "Produto 3" },
                new Product { Id = 1, Name = "Produto 4" },
                new Product { Id = 1, Name = "Produto 5" },
                new Product { Id = 1, Name = "Produto 6" },
                new Product { Id = 1, Name = "Produto 7" },
                new Product { Id = 1, Name = "Produto 8" },
                new Product { Id = 1, Name = "Produto 9" },
                new Product { Id = 1, Name = "Produto 10" }
            };
        }

        public IEnumerable<Product> Get(int pageSize, int page)
        {
            return Get()
                .Where((user, index) => index > page)
                .Take(pageSize);
        }
    }
}
