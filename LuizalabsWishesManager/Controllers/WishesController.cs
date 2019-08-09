using System;
using System.Collections.Generic;
using System.Linq;
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

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<WishViewModel> Get(int id, [FromQuery] int page_size, int page)
        {
            if (id <= 0) return BadRequest();

            if (page_size <= 0) page_size = 1;
            if (page <= 0) page = 10;

            var wishes = _service.GetById(id, page_size, page);

            if (wishes is null) return NotFound(wishes);

            var wishesModel = _mapper.Map<IEnumerable<WishViewModel>>(wishes);

            return Ok(wishesModel);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] NewWishViewModel wishModel)
        {
            if (wishModel == null) return BadRequest();            

            try
            {
                var wish = _mapper.Map<Wish>(wishModel);
                _service.Add(wish);

                return CreatedAtAction("", wishModel);
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
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
