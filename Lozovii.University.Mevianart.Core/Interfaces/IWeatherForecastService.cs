using Lozovii.University.Mevianart.Models.Weather;

namespace Lozovii.University.Mevianart.Core.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetRandomForecast();
    }
}
