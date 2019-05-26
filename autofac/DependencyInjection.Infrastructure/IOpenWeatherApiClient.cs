using DependencyInjection.Infrastructure.WeatherApiModels;
using Refit;
using System.Threading.Tasks;

namespace DependencyInjection.Infrastructure
{
    public interface IOpenWeatherApiClient
    {
        [Get("/forecast")]
        Task<CityForecast> GetDaily(string q, string appId, string units);
    }
}