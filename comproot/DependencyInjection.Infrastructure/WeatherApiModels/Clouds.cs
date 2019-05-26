using Newtonsoft.Json;

namespace DependencyInjection.Infrastructure.WeatherApiModels
{
    public class Clouds
    {
        [JsonProperty("all")]
        public long All { get; set; }
    }
}