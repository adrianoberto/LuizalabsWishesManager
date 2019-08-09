﻿using System;
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
        public ActionResult<IEnumerable<UserViewModel>> Get([FromQuery] int page_size, int page)
        {
            if (page <= 0 || page_size <= 0) return BadRequest();

            var users = _service.GetAll(page, page_size);
            var userModels = _mapper.Map<List<UserViewModel>>((object)users);

            return Ok(userModels);
        }
     
        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] NewUserViewModel userModel)
        {
            if (userModel == null) return BadRequest();

            var user = _mapper.Map<User>(userModel); 

            try
            {
                _service.Add(user);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
