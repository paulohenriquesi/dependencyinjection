using DependencyInjection.Infrastructure.WeatherApiModels;
using Refit;
using System.Threading.Tasks;

namespace DependencyInjection.Infrastructure
{
    public class WeatherApiStore
    {
        private IOpenWeatherApiClient _openWeatherApiClient;

        public WeatherApiStore()
        {
            _openWeatherApiClient = RestService.For<IOpenWeatherApiClient>(
                "https://api.openweathermap.org/data/2.5");
        }
        
        public async Task<CityForecast> GetAsync(string query)
        {
            return await _openWeatherApiClient.GetDaily(query, "1173d40af2ba465d3012faf15bae207a", "metric");
        }
    }
}