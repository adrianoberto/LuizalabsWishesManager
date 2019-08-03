using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using LuizalabsWishesManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuizalabsWishesManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {   
        [HttpGet]
        public IEnumerable<string> Get([FromQuery] int page_size, [FromQuery] int page)
        {
            return new string[] { "value1", "value2" };

            //var product = products.FirstOrDefault((p) => p.Id == id);
            //if (product == null)
            //{
            //    return NotFound();
            //}
            //return Ok(product);
        }
     
        // POST api/values
        [HttpPost]
        public ActionResult<HttpStatusCode> Post([FromBody] NewUser user, [FromServices] User service)
        {
            var success = service.Save(user);

            if (success) return HttpStatusCode.InternalServerError;

            return HttpStatusCode.OK;
        }
    }
}
