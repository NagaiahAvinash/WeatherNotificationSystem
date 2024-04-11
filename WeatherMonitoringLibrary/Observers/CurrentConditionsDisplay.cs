using System;
using WeatherMonitoringLibrary.Interfaces;

namespace WeatherMonitoringLibrary.Observers
{
    /// <summary>
    /// Displays current weather conditions.
    /// Implements IDisplay for showing data.
    /// Name: Avinash Nagaiah
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        public void Display(float temperature, float windSpeed, int airQualityIndex)
        {
            Console.WriteLine($"Current Conditions: Temperature={temperature}F, Wind Speed={windSpeed}mph, AQI={airQualityIndex}");
        }
    }
}
