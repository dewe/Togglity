using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Nancy.Hosting.Self;

namespace Toggliatelle.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        NancyHost nancyHost;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            StartToggliatelle();
        }

        private void StartToggliatelle()
        {
            // Create namespace reservations manually with the (elevated) command(s):
            // netsh http add urlacl url=http://+:1337/ user=Everyone"}
            // See http://msdn.microsoft.com/en-us/library/ms733768.aspx for more information.

            nancyHost = new NancyHost(new Uri("http://localhost:1337"));
            nancyHost.Start();


        }
    }
}