using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace WebApplication9
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "NewRoute",
                url: "usersettings/{id}",
                defaults: new { controller = "User", action = "Settings" },
                constraints: new {id=new RangeRouteConstraint(1,999)}
            );
            routes.MapRoute(
               name: "ShopBuy",
               url: "newOrder/{controller}/{action}",
               defaults: new { controller = "Shop", action = "Buy" }
           );
            routes.MapRoute(
                name: "Default1",
                url: "Home/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { action = new MaxLengthRouteConstraint(5) }
            );
            routes.MapRoute(
                name: "RouteAdmin",
                url: "Admin/{action}/{id}",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional },
                constraints: new { action = @"\w*setup$" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { controller = "Shop|User" }
            );
        }
    }
}
