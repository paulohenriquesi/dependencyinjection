using System.Threading.Tasks;
using DependencyInjection.Application;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.WeatherSite.Controllers
{
    public class HomeController : Controller
    {
        private ForecastReader _forecastReader;

        public HomeController()
        {
            _forecastReader = new ForecastReader();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> GetWeather(string query)
        {
            var result = await _forecastReader.ReadAsync(query);
            return View("Index", result);
        }
    }
}