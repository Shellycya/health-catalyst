using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using HealthCatalyst.Context;
using System.Data.Entity;

namespace HealthCatalyst
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<PersonContext>(new DropCreateDatabaseIfModelChanges<PersonContext>());
        }
    }
}
