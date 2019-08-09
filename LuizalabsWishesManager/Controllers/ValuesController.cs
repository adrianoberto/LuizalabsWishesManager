using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using LuizalabsWishesManager.Data;
using LuizalabsWishesManager.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LuizalabsWishesManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //var options = new DbContextOptionsBuilder<LuizalabsWishesManagerContext>()
            //   .UseInMemoryDatabase(databaseName: "luizalabs")
            //   .Options;

            //// Insert seed data into the database using one instance of the context
            //using (var context = new LuizalabsWishesManagerContext(options))
            //{
            //    var lastProduct = context.Products.LastOrDefault();

            //    int id = 1;
            //    if (lastProduct != null) id += 1; 

            //    context.Products.Add(new Domains.Models.Product { Id = id, Name= "teste" + id });
            //    context.SaveChanges();
            //}

            //// Use a clean instance of the context to run the test
            //using (var context = new LuizalabsWishesManagerContext(options))
            //{
            //    var service = new ProductRepository(context);
            //    var result = service.List();
            //}


            //Add_writes_to_database();
            //Find_searches_url();

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public void Add_writes_to_database()
        {
            var options = new DbContextOptionsBuilder<BloggingContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;

            // Run the test against one instance of the context
            using (var context = new BloggingContext(options))
            {
                var service = new BlogService(context);
                service.Add("http://sample.com");
            }

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new BloggingContext(options))
            {
                var count = context.Blogs.Count();
                var url = context.Blogs.Single().Url;
            }
        }

        public void Find_searches_url()
        {
            var options = new DbContextOptionsBuilder<BloggingContext>()
                .UseInMemoryDatabase(databaseName: "Find_searches_url")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BloggingContext(options))
            {
                context.Blogs.Add(new Blog { Url = "http://sample.com/cats" });
                context.Blogs.Add(new Blog { Url = "http://sample.com/catfish" });
                context.Blogs.Add(new Blog { Url = "http://sample.com/dogs" });
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BloggingContext(options))
            {
                var service = new BlogService(context);
                var result = service.Find("cat");
            }
        }
    }
}
