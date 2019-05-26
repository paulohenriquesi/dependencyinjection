using DependencyInjection.Application;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.WeatherSite.Di
{
    public static class ApplicationModule
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IForecastReader, ForecastReader>();
            services.Decorate<IForecastReader, ForecastLogDecorator>();
            services.Decorate<IForecastReader, ForecastWithErrorHandlingDecorator>();
        }
    }
}
