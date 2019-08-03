using System.Collections.Generic;
using System.Linq;

namespace LuizalabsWishesManager.Models
{
    public class NewUser
    {   
        public string Name { get; set; }
        public string Email { get; set; }
    }


    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        public IEnumerable<User> Get()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "Usuario 1", Email = "usuario1@magalu.com.br" },
                new User { Id = 2, Name = "Usuario 2", Email = "usuario2@magalu.com.br" },
                new User { Id = 3, Name = "Usuario 3", Email = "usuario3@magalu.com.br" }
            };
        }

        public IEnumerable<User> Get(int pageSize, int page)
        {
            return Get()
                .Where((user, index) => index > page)
                .Take(pageSize);
        }

        public bool Save(NewUser user)
        {
            return true;
        }
    }
}
