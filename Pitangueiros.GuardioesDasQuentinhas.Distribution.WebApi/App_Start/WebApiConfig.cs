using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Pitangueiros.GuardioesDasQuentinhas.Cross.IoC;
using Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi.IoC;

namespace Pitangueiros.GuardioesDasQuentinhas.Distribution.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Services.Replace(typeof(IHttpControllerActivator), new AtivadorControladorApi(GerenciadorIoC.Instancia));

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
