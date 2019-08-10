using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Repositories;

namespace LuizalabsWishesManager.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository) : base(repository) => _repository = repository;
    }
}
