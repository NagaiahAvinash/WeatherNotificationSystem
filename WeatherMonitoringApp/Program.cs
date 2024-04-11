using System;
using System.Threading;
using WeatherMonitoringLibrary.Singleton;
using WeatherMonitoringLibrary.Factory;

class Program
{
    static void Main(string[] args)
    {
        // Obtain the singleton instance of WeatherData
        var weatherData = WeatherData.Instance;

        // Create display elements
        var currentDisplay = WeatherStation.CreateDisplay("current");
        var statisticsDisplay = WeatherStation.CreateDisplay("statistics");
        var forecastDisplay = WeatherStation.CreateDisplay("forecast");

        // Register the display elements as observers
        weatherData.RegisterObserver(currentDisplay);
        weatherData.RegisterObserver(statisticsDisplay);
        weatherData.RegisterObserver(forecastDisplay);

        // Simulate receiving new weather data
        // I have writen the code to output 5 notifications. we can reduce or increase as per our liking from the below code.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nWeather Notification {i+1}:");
            weatherData.GenerateNewWeatherData();
            Thread.Sleep(2000); // it will Pause for 2 seconds to simulate time between data updates
        }
    }
}
