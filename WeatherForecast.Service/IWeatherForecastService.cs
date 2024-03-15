using WeatherForecast.Models;

namespace WeatherForecast.Service
{
    public interface IWeatherForecastService
    {
        Task<List<IWeatherForecastModel>> GetForecasts(DateTime date, string city, string country);
    }
}
