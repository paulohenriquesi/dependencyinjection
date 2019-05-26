using DependencyInjection.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace DependencyInjection.WeatherSite.Di
{
    public static class InfrastructureModule
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {

            services.AddTransient<IWeatherApiStore, WeatherApiStore>();
            services.AddTransient(
                x => RestService.For<IOpenWeatherApiClient>("https://api.openweathermap.org/data/2.5"));
        }
    }
}
