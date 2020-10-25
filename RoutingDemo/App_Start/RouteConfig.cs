using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "Students",
            //    url: "Students",
            //    defaults: new { controller = "Student", action = "GetAllStudents" }
            //);

            //routes.MapRoute(
            //    name: "GetStudent",
            //    url: "Students/{id}",
            //    defaults: new { controller = "Student", action = "GetStudent", id = UrlParameter.Optional },
            //    constraints: new { id = @"\d+"}
            //);

            //routes.MapRoute(
            //    name: "GetStudentAddress",
            //    url: "Students/{id}/Address",
            //    defaults: new { controller = "Student", action = "GetStudentAddress", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "GetAllStudents", id = UrlParameter.Optional }
            );
        }
    }
}
