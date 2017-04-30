using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

         
            routes.MapRoute(
                name: "home",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );


            routes.MapRoute(
                name: "students.index",
                url: "students/",
                defaults: new { controller = "Student", action = "index" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new String[] { "GET" }) }
            );

            routes.MapRoute(
                name:"students.create",
                url: "students/create",
                defaults: new { controller = "Student", action = "create"},
                constraints: new { HttpMethod = new HttpMethodConstraint(new String[] { "GET" }) }
            );

            routes.MapRoute(
                name: "students.store",
                url: "students/create",
                defaults: new { controller = "Student", action = "create" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new String[] { "POST" }) }
            );

            routes.MapRoute(
                name: "students.edit",
                url: "students/{id}/edit",
                defaults: new { controller = "Student", action = "edit" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new String[] { "GET" }) }
            );

            routes.MapRoute(
                name: "students.update",
                url: "students/{id}/edit",
                defaults: new { controller = "Student", action = "edit" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new String[] { "POST" }) }
            );

            routes.MapRoute(
                name: "students.destroy",
                url: "students/{id}/",
                defaults: new { controller = "Student", action = "destroy" },
                constraints: new { HttpMethod = new HttpMethodConstraint(new String[] { "POST" }) }
            );








        }
    }
}