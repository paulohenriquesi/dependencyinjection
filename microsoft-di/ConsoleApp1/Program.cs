using System;
using System.Threading.Tasks;
using DependencyInjection.Application;
using DependencyInjection.WeatherSite.Di;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var service = new ServiceCollection();

            service.AddApplication();
            service.AddInfrastructure();
            service.AddLog();

            var serviceProvider = service.BuildServiceProvider();

            var forecastReader = serviceProvider.GetService<IForecastReader>();

            var response = await forecastReader.ReadAsync("Barueri, BR");

            Console.WriteLine(response.CityName);
        }
    }
}
