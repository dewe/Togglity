using System.Collections.Generic;
using System.Web.Http;

namespace Togglity.Server.Controllers
{
    public class TogglesController : ApiController
    {
        // GET api/toggles
        public IDictionary<string,bool> Get()
        {
            return new Dictionary<string, bool>()
            {
                {"Toggle1", true},
                {"Toggle2", true},
                {"Toggle3", false}
            };
        }
    }
}
