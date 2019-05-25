using Newtonsoft.Json;

namespace DependencyInjection.Infrastructure.WeatherApiModels
{
    public class Rain
    {
        [JsonProperty("3h")]
        public decimal The3H { get; set; }
    }
}