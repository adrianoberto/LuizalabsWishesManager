using LuizalabsWishesManager.Services;
using LuizalabsWishesManager.Shared;
using NUnit.Framework;
using RestSharp;

namespace Tests
{
    public class ProductTest
    {
        private IProductService _service;

        //public ProductTest(IProductService service) => _service = service;


        [SetUp]
        public void Setup(IProductService service)
        {
            _service = service;
        }

        [Test]
        public void NewProductTest()
        {
            _service.Add(new LuizalabsWishesManager.Domains.Models.Product());
            var client = new RestClient("http://localhost:44335/api/users");
            client.Execute(new RestRequest(Method.GET));

            Assert.Pass();
        }
    }
}