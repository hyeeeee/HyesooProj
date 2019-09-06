using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyesooProj.Infrastructure.Ef;
using HyesooProj.Infrastructure.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HyesooProj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly HyesooProjDbContext _dbContext;

        public ValuesController(HyesooProjDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            object result = await this._dbContext.FootPrints
                .Include(o => o.CoffeeTimes)
                .Select(o => new
                {
                    Id = o.Id,
                    Name = o.Name,
                    Coffee = o.CoffeeTimes
                })
                .ToListAsync().ConfigureAwait(false);

            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody] string name)
        //{
        //    //var footPrint = new FootPrintk
        //}

        [HttpPost]
        public async Task Post([FromBody]string name)
        {
            var footPrint = new FootPrint()
            {
                Name = name,
                Daily = new DailyFootPrint() { Name = "기매수" },
                CoffeeTimes = new List<CoffeeTime>() { new CoffeeTime() { When = DateTime.Now, With = "지성책임/혜수책임/etc.." } }
            };

            this._dbContext.FootPrints.Add(footPrint);

            await this._dbContext.SaveChangesAsync().ConfigureAwait(false);
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody]string value)
        {
            FootPrint footPrint = await this._dbContext.FootPrints.FirstOrDefaultAsync(o => o.Id == id).ConfigureAwait(false);

            footPrint.Name = value;

            await this._dbContext.SaveChangesAsync().ConfigureAwait(false);
        }
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
