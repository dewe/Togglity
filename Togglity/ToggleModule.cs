using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace Togglity
{
    public class ToggleModule : NancyModule
    {
        public ToggleModule()
        {
            Get["/"] = _ => Response.AsJson("Togglity root");
        }
    }
}
