using Pazzo_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Pazzo_test
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //important 
        //在MVC项目中，建议每个request, 使用一个Context
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Items["db"] = new NorthwindEntities();
        }
        
        protected virtual void Application_EndRequest()
        {
            var entityContext = HttpContext.Current.Items["db"] as NorthwindEntities;
            if (entityContext != null)
                entityContext.Dispose();
        }
    }
}
