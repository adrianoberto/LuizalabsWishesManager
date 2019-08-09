using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.ViewModels;
using LuizalabsWishesManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LuizalabsWishesManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _service;

        public ProductsController(IMapper mapper, IProductService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductViewModel>> Get([FromQuery] int page_size, int page)
        {
            if (page <= 0 || page_size <= 0) return BadRequest();

            var products = _service.GetAll(page_size, page);
            var productsModel = _mapper.Map<IEnumerable<ProductViewModel>>(products);

            return Ok(productsModel); 
        }
     
        // POST api/values
        [HttpPost]
        public ActionResult<HttpStatusCode> Post([FromBody] NewProductViewModel productModel)
        {
            try
            {
                var product = _mapper.Map<Product>(productModel);
                _service.Add(product);

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
