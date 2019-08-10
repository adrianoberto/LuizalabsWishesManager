using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Services;
using LuizalabsWishesManager.Shared;
using NUnit.Framework;
using RestSharp;

namespace Tests
{
    public class UserTest
    {
        private IUserService _service;        


        [SetUp]
        public void Setup(IUserService service)
        {
            _service = service;
        }

        [Test]
        public void NewUserTest()
        {
           
        }
    }
}