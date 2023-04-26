using Microsoft.AspNetCore.Mvc;
using Lozovii.University.Mevianart.Core.Interfaces;
using Lozovii.University.Mevianart.Models.Weather;

namespace Lozovii.University.Mevianart.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _forecastService;

        public WeatherForecastController(IWeatherForecastService forecastService)
        {
            _forecastService = forecastService;
        }

        [HttpGet]
        [Route("Get")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _forecastService.GetRandomForecast();
        }
    }
}