using System.Collections.Generic;

namespace DependencyInjection.Application.Models
{
    public class CityForecast
    {
        public string Query { get; set; }
        public long CityId { get; set; }
        public string CityName { get; set; }
        public List<Forecast> Forecasts { get; set; }
    }
}