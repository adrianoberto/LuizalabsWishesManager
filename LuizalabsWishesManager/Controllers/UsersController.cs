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
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;

        public UsersController(IMapper mapper, IUserService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserViewModel>> Get([FromQuery] int? page_size, int? page)
        {
            if(page == null) page = 1;
            if(page_size == null) page_size = 10;

            if (page <= 0 || page_size <= 0) return BadRequest();

            var users = _service.GetAll((int)page, (int)page_size);

            if (users == null || !users.Any()) return NotFound(users);

            var userModels = _mapper.Map<List<UserViewModel>>(users);

            return Ok(userModels);
        }
     
        // POST api/users
        [HttpPost]
        public ActionResult Post([FromBody] NewUserViewModel userModel)
        {
            if (userModel == null) return BadRequest();

            var user = _mapper.Map<User>(userModel); 

            try
            {
                _service.Add(user);
                return StatusCode(HttpStatusCode.Created.GetHashCode(), user);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
