using System;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Application.Models;
using DependencyInjection.Infrastructure;

namespace DependencyInjection.Application
{
    public class ForecastReader
    {
        private WeatherApiStore _weatherApiStore;

        public ForecastReader()
        {
            _weatherApiStore = new WeatherApiStore();
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