using LuizalabsWishesManager.Data.Repositories;
using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuizalabsWishesManager.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        //public bool Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<User> List(int pageSize, int page)
        //{
        //    return GetFakeUsers()
        //        .Where((user, index) => index >= page -1)
        //        .Take(pageSize);
        //}

        //public IEnumerable<User> List()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Save(User user)
        //{
        //    #region code protected
        //    if (user == null) throw new NullReferenceException("user required");
        //    #endregion
        //}

        //public bool Update(int id, User user)
        //{
        //    throw new NotImplementedException();
        //}

        //private IEnumerable<User> GetFakeUsers()
        //{
        //    return new List<User>()
        //    {
        //        new User { Id = 1, Name = "Usuario 1", Email = "usuario1@magalu.com.br" },
        //        new User { Id = 2, Name = "Usuario 2", Email = "usuario2@magalu.com.br" },
        //        new User { Id = 3, Name = "Usuario 3", Email = "usuario3@magalu.com.br" }
        //    };
        //}
    }
}
