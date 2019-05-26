using System;

namespace DependencyInjection.Application.Models
{
    public class Forecast
    {
        public DateTime Date { get; set; }
        public string WeatherCondition { get; set; }
        public decimal MaxTemperature { get; set; }
        public decimal MinTemperature { get; set; }
    }
}