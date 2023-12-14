using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvno_admin
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "App", action = "Dashboards", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Dashboard",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "App", action = "Dashboards", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Tools",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "App", action = "Tools", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Subscribers",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Subscribers", action = "SubscribersList", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Create_New_Subscriber",
                url: "app/{controller}/{action}/{id}",
                defaults: new { controller = "Subscribers", action = "CreateNewSubscriber", id = UrlParameter.Optional }
            );

        }
    }
}
