﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace Togglity.Api
{
    public class ToggleModule : Nancy.NancyModule
    {
        public ToggleModule()
        {
            Get["/"] = _ => "Togglity root";
        }
    }
}