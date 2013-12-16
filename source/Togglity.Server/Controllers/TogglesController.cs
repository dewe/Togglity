using System.Collections.Generic;
using System.Web.Http;
using Togglity.Server.Models;

namespace Togglity.Server.Controllers
{
    public class TogglesController : ApiController
    {
        // GET api/toggles
        public Toggles Get()
        {
            return new Toggles() 
            {
                new Feature {Name = "Toggle1", Enabled = true},
                new Feature {Name = "Toggle2", Enabled = true},
                new Feature {Name = "Toggle3", Enabled = false}
            };
        }
    }
}
