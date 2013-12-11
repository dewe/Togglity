using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Togglity.Server.Models;

namespace Togglity.Server.Controllers
{
    public class TogglesController : ApiController
    {
        // GET api/toggles
        public Toggles Get()
        {
            return new Toggles
            {
                new Feature {Name = "Toggle1", Enabled = true}
            };
        }
    }
}
