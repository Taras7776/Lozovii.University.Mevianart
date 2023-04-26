using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Lozovii.University.Mevianart.Core.Interfaces;
using Lozovii.University.Mevianart.Core.Services;
using Lozovii.University.Mevianart.Models.Configuration;

namespace Lozovii.University.Mevianart.Core
{
    public static class DIConfiguration
    {
        public static void RegisterCoreDependencies(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
        }

        public static void RegisterCoreConfiguration(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.Configure<AppConfig>(configuration.GetSection("AppConfig"));
        }
    }
}
