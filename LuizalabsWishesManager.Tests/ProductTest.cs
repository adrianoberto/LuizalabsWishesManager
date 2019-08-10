using LuizalabsWishesManager.Services;
using LuizalabsWishesManager.Shared;
using NUnit.Framework;
using RestSharp;

namespace Tests
{
    public class ProductTest
    {
        private IProductService _service;

        [SetUp]
        public void Setup(IProductService service)
        {
            _service = service;
        }
    }
}