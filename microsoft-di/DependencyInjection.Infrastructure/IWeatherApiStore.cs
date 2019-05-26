using System.Threading.Tasks;
using DependencyInjection.Infrastructure.WeatherApiModels;

namespace DependencyInjection.Infrastructure
{
    public interface IWeatherApiStore
    {
        Task<CityForecast> GetAsync(string query);
    }
}