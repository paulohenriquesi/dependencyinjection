using DependencyInjection.Application.Models;
using DependencyInjection.Infrastructure;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Application
{
    public class ForecastReader
    {
        private WeatherApiStore _weatherApiStore;

        public ForecastReader(WeatherApiStore weatherApiStore)
        {
            _weatherApiStore = weatherApiStore;
        }
        
        public async Task<CityForecast> ReadAsync(string zipCode)
        {
            var result = await _weatherApiStore.GetAsync(zipCode);

            return new CityForecast
            {
                CityId = result.City.Id,
                CityName = result.City.Name,
                Forecasts = result.List.Select(x =>
                    new Forecast
                    {
                        Date = DateTime.Parse(x.DtTxt),
                        MaxTemperature = x.Main.TempMax,
                        MinTemperature = x.Main.TempMin,
                        WeatherCondition = x.Weather[0].Description
                    }).ToList()
            };
        }
    }
}