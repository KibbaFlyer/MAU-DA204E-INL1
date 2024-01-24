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
        private DateTime _currentTime;
        private string _timezone;

        public async Task Start()
        {
            // The start task write out questions for the user, collects answers, and then calls the async CallWeatherAPI before it finally writes out the answer
            Console.Title = "Weather Stations";
            Console.WriteLine("Welcome to the Kristoffer Weather Service!\n" +
                "Here we provide you with current temperature for a specific longitude and latitude\n");
            Console.WriteLine("Which unit would you like your weather in? (c/f)");
            _unit = Console.ReadLine() == "c" ? "celsius" : "fahrenheit";
            Console.WriteLine();
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
            Console.WriteLine($"The temperature at {_latitude} / {_longitude} is: {_currentTemperature} {_unit}" +
                $"\nAnd the time of the forecast is: {_currentTime} {_timezone}");
        }
        // This task is using the Weather Forecast API on Open-Meteo: https://open-meteo.com/en/docs/
        // This method is calling an external open API in order to get weather data of the latitude and longitude entered by the user.
        private async Task CallWeatherAPI()
        {
            // First we define the URL
            string apiUrl = $"https://api.open-meteo.com/v1/forecast?latitude={_latitude}&longitude={_longitude}&current=temperature_2m&temperature_unit={_unit}";
            // Then we create a HttpClient in order to send the message to the URL
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                // If the response is ok
                if (response.IsSuccessStatusCode)
                {
                    // We collect the data from the response and set it to our parameters
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var jsonObject = JsonDocument.Parse(jsonResponse).RootElement;
                    _currentTemperature = jsonObject.GetProperty("current").GetProperty("temperature_2m").GetDouble();
                    _currentTime = jsonObject.GetProperty("current").GetProperty("time").GetDateTime();
                    _timezone = jsonObject.GetProperty("timezone").ToString();
                }
                // If the call was unsucessful
                else
                {
                    // Output error code to user in the console
                    Console.WriteLine($"API request failed with status code: {response.StatusCode}");
                }
            }
        }
    }
}
