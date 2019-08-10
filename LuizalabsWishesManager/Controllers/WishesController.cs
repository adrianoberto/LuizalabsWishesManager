using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using LuizalabsWishesManager.Domains.Models;
using LuizalabsWishesManager.Domains.Services;
using LuizalabsWishesManager.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuizalabsWishesManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWishService _service;

        public WishesController(IMapper mapper, IWishService service)
        {
            _mapper = mapper;
            _service = service;
        }

        // GET api/wishes/5
        [HttpGet("{id}")]
        public ActionResult<ProductViewModel> Get(int id, [FromQuery] int? page_size, int? page)
        {
            if (id <= 0) return BadRequest();

            if (page_size == null) page_size = 1;
            if (page == null) page = 10;

            if (page == 0 || page_size == 0) return BadRequest();

            var products = _service.GetAll(id, (int) page, (int) page_size);

            if (products is null || !products.Any()) return NotFound(products);

            var productsModel = _mapper.Map<IEnumerable<ProductViewModel>>(products);

            return Ok(productsModel);
        }

        // POST api/wishes
        [HttpPost("{userId}")]
        public ActionResult Post(int userId, [FromBody] List<ProductWishViewModel> productsModel)
        {
            if (productsModel == null) return BadRequest();            

            try
            {
                var products = _mapper.Map<List<WishProduct>>(productsModel);
                
                _service.Add(userId, products);

                return StatusCode(
                    HttpStatusCode.Created.GetHashCode()                    
                ); 
            }
            catch
            {
                return BadRequest();
            }
        }


        // DELETE api/wishes/5
        [HttpDelete("{userId}/{productId}")]
        public ActionResult Delete(int userId, int productId)
        {
            if (userId <= 0 || productId <= 0) return BadRequest();

            try
            {
                _service.Delete(userId, productId);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
