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
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Subscribers", action = "CreateNewSubscriber", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "View_Subscriber",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Subscribers", action = "ViewSubscriber", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "User_Management",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "UserManagement", action = "UsersList", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Packages",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Packages", action = "PackagesList", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Create_New_Package",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Packages", action = "CreateNewPackages", id = UrlParameter.Optional }
            );
        }
    }
}
