using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceThree.API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value from service three..!" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value from service three..!";
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return $"{value}: value from service three..!";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
