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
        private readonly IToggleCentral _toggleCentral;
        private readonly IToggleAdmin _toggles;

        public TogglesController(IToggleCentral toggleCentral, IToggleAdmin toggles)
        {
            _toggleCentral = toggleCentral;
            _toggles = toggles;
        }

        [HttpPost]
        [Route("toggles/webhook")]
        public HttpResponseMessage WebHook([FromBody]string value)
        {
            _toggles.Set(_toggleCentral.GetToggles());

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
