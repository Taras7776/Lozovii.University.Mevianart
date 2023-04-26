using Microsoft.AspNetCore.Mvc.RazorPages;
using Lozovii.University.Mevianart.Core.Interfaces;
using Lozovii.University.Mevianart.Models.Weather;

namespace Lozovii.University.Mevianart.Web.Pages
{
    public class WeatherForecastModel : PageModel
    {
        public IList<WeatherForecast> Forecasts { get; set; }

        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastModel(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        public void OnGet()
        {
            Forecasts = _weatherForecastService.GetRandomForecast().ToList();
        }
    }
}