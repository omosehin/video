using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Cleaner way mvc5

            routes.MapMvcAttributeRoutes();

            /*
            //old custom route
            routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { Controller = "Movies", Action = "ByReleasedDate" },
              //  new {year =@"\d{4}",month = @"\d{2}" }); //d mean digit
                new {year =@"2015||2016",month = @"\d{2}" }); //year constraints
            */


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", //If our part does not contain any of these it will route back to home controller.If the url only has controller with no action it will go back to the Index in defaults
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
