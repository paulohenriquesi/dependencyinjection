using Autofac;
using DependencyInjection.Application;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.WeatherSite.Di
{
    public class ApplicationModule : Module
    {
        public bool LoggingEnabled { get; set; }

        public ApplicationModule(bool loggingEnabled)
        {
            LoggingEnabled = loggingEnabled;
        }

        protected override void Load(ContainerBuilder container)
        {
            container.RegisterType<ForecastReader>().As<IForecastReader>();

            if (LoggingEnabled)
                container.RegisterDecorator<ForecastLogDecorator, IForecastReader>();

            container.RegisterDecorator<ForecastWithErrorHandlingDecorator, IForecastReader>();
        }
    }
}
