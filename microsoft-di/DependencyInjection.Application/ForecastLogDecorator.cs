using System;
using System.Threading.Tasks;
using DependencyInjection.Application.Models;
using Serilog;

namespace DependencyInjection.Application
{
    public class ForecastLogDecorator : IForecastReader
    {
        private IForecastReader _forecastReader;
        private ILogger _logger;

        public ForecastLogDecorator(IForecastReader forecastReader, ILogger logger)
        {
            _forecastReader = forecastReader ?? throw new ArgumentNullException(nameof(forecastReader));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task<CityForecast> ReadAsync(string query)
        {
            _logger.Information("Query " + query);

            return _forecastReader.ReadAsync(query);
        }
    }
}