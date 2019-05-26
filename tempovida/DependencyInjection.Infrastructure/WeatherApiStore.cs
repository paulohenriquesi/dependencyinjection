using DependencyInjection.Infrastructure.WeatherApiModels;
using System;
using System.Threading.Tasks;

namespace DependencyInjection.Infrastructure
{
    public class WeatherApiStore : IWeatherApiStore
    {
        private IOpenWeatherApiClient _openWeatherApiClient;

        public WeatherApiStore(IOpenWeatherApiClient openWeatherApiClient)
        {
            _openWeatherApiClient = openWeatherApiClient ?? throw new ArgumentNullException(nameof(openWeatherApiClient));
        }
        
        public async Task<CityForecast> GetAsync(string query)
        {
            return await _openWeatherApiClient.GetDaily(query, "1173d40af2ba465d3012faf15bae207a", "metric");
        }
    }
}