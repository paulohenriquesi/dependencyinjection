using Autofac;
using Serilog;

namespace DependencyInjection.WeatherSite.Di
{
    public class LogModule : Module
    {
        protected override void Load(ContainerBuilder container)
        {
            container.Register<ILogger>(x =>
                new LoggerConfiguration()
                    .WriteTo.Console()
                    .CreateLogger()).InstancePerRequest();
        }
    }
}
