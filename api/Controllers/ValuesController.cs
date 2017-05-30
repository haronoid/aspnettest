using System;
using System.Web.Http;

namespace api.Controllers
{
    public class ValuesController : ApiController
    {
        public ValuesController()
        {
        }

        public string GetValue()
        {
            return "value";
        }
    }
}
