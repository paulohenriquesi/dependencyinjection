using System;
using System.Threading.Tasks;
using DependencyInjection.Application;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.WeatherSite.Controllers
{
    public class HomeController : Controller
    {
        private IForecastReader _forecastReader;

        public HomeController(IForecastReader forecastReader)
        {
            _forecastReader = forecastReader ?? throw new ArgumentNullException(nameof(forecastReader));
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