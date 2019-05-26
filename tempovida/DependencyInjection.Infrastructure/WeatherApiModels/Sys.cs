using Newtonsoft.Json;

namespace DependencyInjection.Infrastructure.WeatherApiModels
{
    public class Sys
    {
        [JsonProperty("pod")]
        public string Pod { get; set; }
    }
}