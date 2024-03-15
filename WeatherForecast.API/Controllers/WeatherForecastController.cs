using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Service;

namespace WeatherForecast.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastService _weatherForecastService;

        public WeatherForecastController(WeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IActionResult> GetForecast(DateTime date, string city, string country)
        {
            var forecasts = await _weatherForecastService.GetForecasts(date, city, country);
            return Ok(forecasts);
        }
    }
}
