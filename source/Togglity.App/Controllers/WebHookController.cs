using System.Net;
using System.Net.Http;
using System.Web.Http;
using Togglity.App.Services;
using Togglity.App.Togglity;

namespace Togglity.App.Controllers
{
    public class WebHookController : ApiController
    {
        private readonly ITogglesService _togglesService;
        private readonly ITogglesAdmin _toggles;

        public WebHookController(ITogglesService togglesService, ITogglesAdmin toggles)
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
