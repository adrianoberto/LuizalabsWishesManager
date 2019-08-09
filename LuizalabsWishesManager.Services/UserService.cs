using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuizalabsWishesManager.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }

        //public bool Delete(int id)
        //{
        //    return _repository.Delete(id);
        //}

        //public IEnumerable<User> List()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<User> List(int page, int pageSize)
        //{
        //    return _repository.List(page, pageSize);
        //}

        //public bool Save(User user)
        //{
        //    return _repository.Save(user);
        //}

        //public bool Update(int id, User user)
        //{
        //    return _repository.Update(id, user);
        //}
    }
}
