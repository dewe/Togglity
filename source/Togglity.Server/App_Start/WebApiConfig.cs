using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Togglity.Server
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            ConfigureJsonOnlyContentNegotion(config);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void ConfigureJsonOnlyContentNegotion(HttpConfiguration config)
        {
            var jsonFormatter = new JsonMediaTypeFormatter();
            jsonFormatter.Indent = true;
            
            config.Services.Replace(
                typeof (IContentNegotiator), 
                new JsonContentNegotiator(jsonFormatter));
        }
    }
}
