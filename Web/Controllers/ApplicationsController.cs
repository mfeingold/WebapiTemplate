using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Web.DataAccess;
using Web.Models;

namespace Web.Controllers
{
    public class ApplicationsController : ApiController
    {
        public ApplicationsController(IRepository repository) {
            
        }

        //
        // GET: /Applications/
        
        public object GetApplications() {

            using (var db = (IRepository)new Repository())
            {
                return new
                {
                    theList = (from b in db.Entity<Application>() select b.URL).ToArray()
                };
            }
            
        }

    }
}
