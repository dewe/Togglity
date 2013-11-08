using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Togglity.Api;
using Togglity.Api.Services;

namespace Togglity.Api.Controllers
{
    public class TogglesController : ApiController
    {
        private readonly ITogglesService _toggleService;

        public TogglesController(ITogglesService toggleService)
        {
            _toggleService = toggleService;
        }

        // POST toggles/webhook
        [HttpPost]
        [Route("toggles/webhook")]
        public HttpResponseMessage WebHook([FromBody]string value)
        {
            _toggleService.GetToggles();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
