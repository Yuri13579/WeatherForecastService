using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherForecast.Models;

namespace WeatherForecast.Service
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<IWeatherForecastModel>> GetForecasts(DateTime date, string city, string country)
        {
            var forecasts = new List<IWeatherForecastModel>();
            
            var apiKeyWeatherapi = "3018489d78654525af0164601241503";
            var apiUrlWeatherapi = $"https://api.weatherapi.com/v1/forecast.json?key={apiKeyWeatherapi}&q={city},{country}&dt={date:yyyy-MM-dd}";
            var apiKeyOpenweathermap ="2bd1cd460cce0d1574a375c3613ec3e5";
            var apiUrlOpenweathermap = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&cnt=1&APPID={apiKeyOpenweathermap}";
            var apiKeyVisualcrossing = "KBTJGCMXJHK3NN9WQGB3JRFFB";
            var apiUrlVisualcrossing = $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}?key={apiKeyVisualcrossing}";

            var forecastWeatherapiJsonTask = GetForecastFromAPI(apiUrlWeatherapi);
            var forecastOpenweathermapJsonTask = GetForecastFromAPI( apiUrlOpenweathermap);
            var forecastVisualcrossingJsonTask = GetForecastFromAPI(apiUrlVisualcrossing);
            Task.WaitAll(forecastWeatherapiJsonTask, forecastOpenweathermapJsonTask, forecastVisualcrossingJsonTask);

            var forecastWeatherapiJson = forecastWeatherapiJsonTask.Result;
            var forecastOpenweathermapJson = forecastOpenweathermapJsonTask.Result;
            var forecastVisualcrossingJson = forecastVisualcrossingJsonTask.Result;
            
            try { 
                var forecastWeatherapi = JsonSerializer.Deserialize<ApiWeatherapiResult>(forecastWeatherapiJson);
                forecasts.Add(forecastWeatherapi);
                var forecastOpenweathermap = JsonSerializer.Deserialize<ApiOpenWeathermapResult>(forecastOpenweathermapJson);
                forecasts.Add(forecastOpenweathermap);
                var forecastVisualcrossing = JsonSerializer.Deserialize<WeatherVisualcrossing>(forecastVisualcrossingJson);
                forecasts.Add(forecastVisualcrossing);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return forecasts;
        }

        private async Task<string> GetForecastFromAPI(string apiUrl)
        {
            string json = string.Empty;
            
            try
            {
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                json = await response.Content.ReadAsStringAsync();
            } catch (Exception ex)
            {
                Console.WriteLine($"Error with {apiUrl} {ex.Message}");
                 return json;
            }
            
            return json;
        }


    }
}
