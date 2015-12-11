using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using ODataDemo.App_Start;

namespace ODataDemo
{
    //public class Global : HttpApplication
    //{
    //    void Application_Start(object sender, EventArgs e)
    //    {
    //        // Code that runs on application startup
    //        AreaRegistration.RegisterAllAreas();
    //        GlobalConfiguration.Configure(WebApiConfig.Register);
    //        RouteConfig.RegisterRoutes(RouteTable.Routes);

    //    }
    //}

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(config =>
            {
                WebApiConfig.Register(config);
                ODataConfig.Register(config);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                //FormatterConfig.Register(config);
            });
        }
    }
}