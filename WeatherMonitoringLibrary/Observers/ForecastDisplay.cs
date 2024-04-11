using System;
using WeatherMonitoringLibrary.Interfaces;

namespace WeatherMonitoringLibrary.Observers
{
    /// <summary>
    /// Displays weather forecast based on air quality index.
    /// Implements IDisplay for showing data.
    /// Name: Avinash Nagaiah
    /// </summary>
    public class ForecastDisplay : IDisplay
    {
        private int lastAirQualityIndex = 0;

        public void Display(float temperature, float windSpeed, int airQualityIndex)
        {
            string forecast = "Forecast: More of the same";
            if (airQualityIndex > lastAirQualityIndex)
            {
                forecast = "Forecast: Air quality is getting worse";
            }
            else if (airQualityIndex < lastAirQualityIndex)
            {
                forecast = "Forecast: Air quality is improving";
            }
            Console.WriteLine(forecast);
            lastAirQualityIndex = airQualityIndex;
        }
    }
}
