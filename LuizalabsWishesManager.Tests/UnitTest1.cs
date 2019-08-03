using LuizalabsWishesManager.Controllers;
using NUnit.Framework;
using RestSharp;

namespace Tests
{
    public class Tests
    {
        private readonly UsersController _controller = new UsersController();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var client = new RestClient("http://localhost:44335/api/users");
            client.Execute(new RestRequest(Method.GET));

            Assert.Pass();
        }
    }
}