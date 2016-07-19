using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RedingtonMiniProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "ApiRoute",
                routeTemplate: "api/{controller}/{action}"
            );
        }
    }
}
