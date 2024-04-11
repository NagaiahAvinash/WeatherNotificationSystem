using System;
using System.Collections.Generic;
using System.Linq;
using WeatherMonitoringLibrary.Interfaces;

namespace WeatherMonitoringLibrary.Observers
{
    /// <summary>
    /// Displays statistical information about weather data.
    /// Implements IDisplay for showing data.
    /// Name: Avinash Nagaiah
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        private List<float> temperatures = new List<float>();

        public void Display(float temperature, float windSpeed, int airQualityIndex)
        {
            temperatures.Add(temperature);
            Console.WriteLine($"Statistics: Avg Temp={temperatures.Average()}F, Max Temp={temperatures.Max()}F, Min Temp={temperatures.Min()}F");
        }
    }
}
