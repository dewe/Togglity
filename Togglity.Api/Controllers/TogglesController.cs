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
        private readonly ITogglesService _togglesService;
        private readonly ITogglesAdmin _toggles;

        public TogglesController(ITogglesService togglesService, ITogglesAdmin toggles)
        {
            _togglesService = togglesService;
            _toggles = toggles;
        }

        [HttpPost]
        [Route("toggles/webhook")]
        public HttpResponseMessage WebHook([FromBody]string value)
        {
            _toggles.SetAllToggles(_togglesService.GetToggles());

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
