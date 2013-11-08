using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Togglity.Api.Controllers
{
    public class TogglesController : ApiController
    {
        // POST toggles/webhook
        [HttpPost]
        [Route("toggles/webhook")]
        public void Post([FromBody]string value)
        {

        }
    }
}
