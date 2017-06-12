using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DeviceMicroservice.Controllers
{
    [Route("api/[controller]")]
    public class MachinesController : Controller
    {
        // GET api/machines
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/machines/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/machines
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/machines/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/machines/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
