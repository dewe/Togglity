using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Togglity.Api;
using Togglity.Api.Models;
using Togglity.Api.Services;

namespace Togglity.Api.Controllers
{
    public class TogglesController : ApiController
    {
        private readonly ITogglesServer _togglesServer;
        private readonly ITogglesAdmin _toggles;

        public TogglesController(ITogglesServer togglesServer, ITogglesAdmin toggles)
        {
            _togglesServer = togglesServer;
            _toggles = toggles;
        }

        [HttpPost]
        [Route("toggles/webhook")]
        public HttpResponseMessage WebHook([FromBody]string value)
        {
            _toggles.SetAllToggles(_togglesServer.GetToggles());

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
