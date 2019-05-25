using DependencyInjection.Application;
using DependencyInjection.Infrastructure;
using Refit;

namespace DependencyInjection.WeatherSite.ServiceLocator
{
    public class ServiceLocator
    {
        public static IOpenWeatherApiClient GetOpenWeatherApiClient()
        {
            return RestService.For<IOpenWeatherApiClient>("https://api.openweathermap.org/data/2.5");
        }

        public static WeatherApiStore GetWeatherApiStore()
        {
            return new WeatherApiStore(GetOpenWeatherApiClient());
        }

        public static ForecastReader GetForecastReader()
        {
            return new ForecastReader(GetWeatherApiStore());
        }
    }
}
