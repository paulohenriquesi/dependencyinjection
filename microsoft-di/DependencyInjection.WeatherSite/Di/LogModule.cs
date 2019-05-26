using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace DependencyInjection.WeatherSite.Di
{
    public static class LogModule
    {
        public static void AddLog(this IServiceCollection services)
        {
            services.AddTransient<ILogger>(x =>
                new LoggerConfiguration()
                    .WriteTo.Console()
                    .CreateLogger());
        }
    }
}
