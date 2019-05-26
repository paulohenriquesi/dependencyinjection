using Autofac;
using DependencyInjection.Infrastructure;
using Refit;

namespace DependencyInjection.WeatherSite.Di
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder container)
        {
            container.RegisterType<WeatherApiStore>().As<IWeatherApiStore>();
            container.Register<IOpenWeatherApiClient>(x =>
                RestService.For<IOpenWeatherApiClient>("https://api.openweathermap.org/data/2.5")).SingleInstance();
        }
    }
}
