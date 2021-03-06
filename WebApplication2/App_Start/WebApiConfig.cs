﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "v1/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Telemetry",
                routeTemplate: "v1/Device/{id}/Telemetry",
                defaults: new { controller = "Device", action = "Telemetry" }
            );
        }
    }
}
