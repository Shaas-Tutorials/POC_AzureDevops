using System.Web.Http;

namespace WebApiProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
               name: "Employee",
               routeTemplate: "api/employee/{id}",
               defaults: new { controller = "EmployeeController", id = RouteParameter.Optional },
               constraints: new { id = "/d+" }
           );

            config.Routes.MapHttpRoute(
                name: "Address",
                routeTemplate: "api/address/{id}",
                defaults: new { controller = "AddressController", id = RouteParameter.Optional },
                constraints: new { id = "/d+" }
            );

            config.Routes.MapHttpRoute(
                name: "Details",
                routeTemplate: "api/details/{id}",
                defaults: new { controller = "DetailsController", id = RouteParameter.Optional },
                constraints: new { id = "/d+" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            config.MapHttpAttributeRoutes();
        }
    }
}
