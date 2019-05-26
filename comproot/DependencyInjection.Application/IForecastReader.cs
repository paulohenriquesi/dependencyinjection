using System.Threading.Tasks;
using DependencyInjection.Application.Models;

namespace DependencyInjection.Application
{
    public interface IForecastReader
    {
        Task<CityForecast> ReadAsync(string query);
    }
}