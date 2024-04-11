using System;
using WeatherMonitoringLibrary.Interfaces;
using WeatherMonitoringLibrary.Observers;

namespace WeatherMonitoringLibrary.Factory
{
    /// <summary>
    /// The WeatherStation class acts as a factory for creating different types of display elements.
    /// Name: Avinash Nagaiah
    /// </summary>
    public class WeatherStation
    {
        public static IDisplay CreateDisplay(string type)
        {
            switch (type.ToLower())
            {
                case "current":
                    return new CurrentConditionsDisplay();
                case "statistics":
                    return new StatisticsDisplay();
                case "forecast":
                    return new ForecastDisplay();
                default:
                    throw new ArgumentException("Unknown display type");
            }
        }
    }
}
