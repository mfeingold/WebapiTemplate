using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Web.DataAccess;
using Web.Models;

namespace Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            using (var db= new Repository()) {
                var application = new Application() {Name = "something", Url = "http://something"};
                db.Applications.Add(application);

                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var e in ex.EntityValidationErrors)
                    {

                        
                    }
                    
                    
                }
                
            }
        }
    }
}