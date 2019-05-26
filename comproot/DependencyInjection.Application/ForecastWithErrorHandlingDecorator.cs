using System;
using System.Net.Http;
using System.Threading.Tasks;
using DependencyInjection.Application.Models;

namespace DependencyInjection.Application
{
    public class ForecastWithErrorHandlingDecorator : IForecastReader
    {
        private IForecastReader _forecastReader;

        public ForecastWithErrorHandlingDecorator(IForecastReader forecastReader)
        {
            _forecastReader = forecastReader ?? throw new ArgumentNullException(nameof(forecastReader));
        }

        public async Task<CityForecast> ReadAsync(string query)
        {
            try
            {
                return await _forecastReader.ReadAsync(query);
            }
            catch (HttpRequestException)
            {
                return new CityForecast();
            }
            catch (Exception e)
            {
                return new CityForecast();
            }
        }
    }
}