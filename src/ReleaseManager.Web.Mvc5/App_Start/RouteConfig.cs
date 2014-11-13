using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ReleaseManager.Web.Mvc5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                string.Empty,
                new { controller = "Release", action = "List" }
            );

            routes.MapRoute(
                "Version", // Route name
                "Version/{releaseName}/{componentName}/{action}", // URL with parameters
                new { controller = "Version", action = "{action}" } // Parameter defaults
            );

            routes.MapRoute(
                "ReleaseList", // Route name
                "Release/List", // URL with parameters
                new { controller = "Release", action = "List" } // Parameter defaults
            );

            routes.MapRoute(
                "ComponentList", // Route name
                "Component/List", // URL with parameters
                new { controller = "Component", action = "List" } // Parameter defaults
            );

            routes.MapRoute(
                "ComponentSave", // Route name
                "Component/Save", // URL with parameters
                new { controller = "Component", action = "Save" } // Parameter defaults
            );

            routes.MapRoute(
                "SaveRelease", // Route name
                "Release/{releaseName}/Save", // URL with parameters
                new { controller = "Release", action = "Save" } // Parameter defaults
            );

            routes.MapRoute(
                "CreateRelease", // Route name
                "Release/Create", // URL with parameters
                new { controller = "Release", action = "Create" } // Parameter defaults
            );

            routes.MapRoute(
                "CreateComponent", // Route name
                "Component/Create", // URL with parameters
                new { controller = "Component", action = "Create" } // Parameter defaults
            );

            routes.MapRoute(
                "NewRelease", // Route name
                "Release/New", // URL with parameters
                new { controller = "Release", action = "New" } // Parameter defaults
            );

            routes.MapRoute(
                "NewComponent", // Route name
                "Component/New", // URL with parameters
                new { controller = "Component", action = "New" } // Parameter defaults
            );

            routes.MapRoute(
                "Component", // Route name
                "Component/{componentName}/{action}", // URL with parameters
                new { controller = "Component", action = "{action}" } // Parameter defaults
            );

            routes.MapRoute(
                "Release", // Route name
                "Release/{releaseName}/{action}", // URL with parameters
                new { controller = "Release", action = "{action}" } // Parameter defaults
            );

        }
    }
}
