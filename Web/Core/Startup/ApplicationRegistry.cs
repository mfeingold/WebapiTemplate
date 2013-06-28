using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap.Configuration.DSL;

namespace Web.Core.Startup
{
    public class ApplicationRegistry : Registry {
        public ApplicationRegistry() {
            Scan(action => {
                    action.AssembliesFromApplicationBaseDirectory();
                    action.LookForRegistries();
                    action.WithDefaultConventions();
                    action.AssemblyContainingType<IBootstrapper>();
                    action.AddAllTypesOf<IBootstrapper>();
                 });
        }
    }

    internal interface IBootstrapper {
        void Configure();
    }
}