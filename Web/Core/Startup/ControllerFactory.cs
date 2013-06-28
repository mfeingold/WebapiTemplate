using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StructureMap;

namespace Web.Core.Startup
{
    public class ControllerFactory : DefaultControllerFactory, IBootstrapper
    {
        public override IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            string key = controllerName.ToLowerInvariant();
            return ObjectFactory.GetNamedInstance<IController>(key);
        }

        public void Configure() {
            ControllerBuilder.Current.SetControllerFactory(this);
        }
    }
}