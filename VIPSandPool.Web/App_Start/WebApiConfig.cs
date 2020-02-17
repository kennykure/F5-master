using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VIPSandPool.Web
{
    public static class WebApiConfig
    { 
        public static void Register(HttpConfiguration config)
       {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",

                // /api/virtualservers

                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }

                );
         }
  
    }
}