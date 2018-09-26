using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WhereIsMyCoffee.Models.InputModels;
using WhereIsMyCoffee.ValueObjects;

namespace WhereIsMyCoffee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        public CoffeeController()
        {

        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<CoffeeShop>> Get()
        {
            return new CoffeeShop[] { new CoffeeShop(Guid.NewGuid(), "Origin Coffee Roasting", new Location(-33.917141, 18.417659)) };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]CoffeeShopInputModel coffeeShopInputModel)
        {
            // add coffee shop here
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            // remove coffee shop here, by id
        }
    }
}
