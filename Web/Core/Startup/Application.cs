using StructureMap;

namespace Web.Core.Startup
{
    public class Application {
        public static IContainer Start() {
            var container = new Container(new ApplicationRegistry());
            foreach (var bootstrapper in container.GetAllInstances<IBootstrapper>())
                bootstrapper.Configure();
            return container;
        }
    }
}