using System.Collections.Generic;
using System.Web.Http;

namespace Togglity.App.Controllers
{
    public class TogglesController : ApiController
    {
        // GET api/toggles
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
