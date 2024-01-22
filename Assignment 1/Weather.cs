using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.Text.Json;

namespace Assignment_1
{
    internal class Weather
    {
        private double _currentTemperature;
        private string _latitude;
        private string _longitude;
        private string _unit;
        private int _forecastLength;

        public async Task Start()
        {
            Console.WriteLine("Welcome to the Kristoffer Weather Service!\n" +
                "Here we provide you with current temperature for a specific longitude and latitude\n");
            Console.WriteLine("Which unit would you like your weather in? (c/f)");
            _unit = Console.ReadLine() == "c" ? "celsius" : "fahrenheit";
            Console.WriteLine("Common latitudes / longitudes are:\n" +
                "Stockholm 59.3328 / 18.0645\n" +
                "Oslo 59.9138 / 10.7387\n" +
                "Vienna 48.2092 / 16.3728\n" +
                "Copenhagen 55.6763 / 12.5681");
            Console.WriteLine();
            Console.WriteLine("Which latitude is your wished location on?");
            _latitude = Console.ReadLine();
            Console.WriteLine("Which longitude is your wished location on?");
            _longitude = Console.ReadLine();
            await CallWeatherAPI();
            Console.WriteLine();
            Console.WriteLine($"The temperature at {_latitude} {_longitude} is:");
            Console.WriteLine(_currentTemperature);
        }
        private void GetWeather(int forecastLength)
        {
            
        }
        // This task is using the Weather Forecast API on Open-Meteo: https://open-meteo.com/en/docs/
        private async Task CallWeatherAPI()
        {
            string apiUrl = $"https://api.open-meteo.com/v1/forecast?latitude={_latitude}&longitude={_longitude}&current=temperature_2m&temperature_unit={_unit}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var jsonObject = JsonDocument.Parse(jsonResponse).RootElement;
                    _currentTemperature = jsonObject.GetProperty("current").GetProperty("temperature_2m").GetDouble();
                }
                else
                {
                    Console.WriteLine($"API request failed with status code: {response.StatusCode}");
                }
            }
        }
    }
}
