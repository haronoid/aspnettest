using System;
using System.Collections.Generic;
using System.Web.Http;

namespace api.Controllers
{
    public class ValuesController : ApiController
    {
        public ValuesController()
        {
        }

        // GET api/Values/
        public IEnumerable<string> Get()
        {
            return new string[] { "value" ,"value2"} ;
        }

        // GET /api/Values/?name=test
        public string GetByName(string name)
        {
            return "my name is " + name;
        }

        // POST api/Values/{id}
        public string Post(string id, [FromBody]string product)
        {
            return "success";
        }
    }
}
