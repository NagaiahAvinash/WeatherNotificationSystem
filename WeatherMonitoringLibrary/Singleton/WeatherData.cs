using System;
using System.Collections.Generic;
using WeatherMonitoringLibrary.Interfaces;

namespace WeatherMonitoringLibrary.Singleton
{
    /// <summary>
    /// Implements a singleton that simulates weather data generation and notifies registered observers with the new data.
    /// Name: Avinash Nagaiah
    /// </summary>
    
    public class WeatherData
    {
        private static WeatherData? instance;
        private List<IDisplay> observers = new List<IDisplay>();

        // Private constructor to prevent external instantiation.
        private WeatherData() {}

        // Public property to access the singleton instance.
        public static WeatherData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WeatherData();
                }
                return instance;
            }
        }

        // Method to register observers.
        public void RegisterObserver(IDisplay observer)
        {
            observers.Add(observer);
        }

        // Method to remove observers.
        public void RemoveObserver(IDisplay observer)
        {
            observers.Remove(observer);
        }

        // Notify all observers with the updated data.
        private void NotifyObservers(float temperature, float windSpeed, int airQualityIndex)
        {
            foreach (var observer in observers)
            {
                observer.Display(temperature, windSpeed, airQualityIndex);
            }
        }

        // Simulates receiving new weather data.
        public void GenerateNewWeatherData()
        {
            // As explained in the class, trying to use random and bit more static values
            // Randomly generate temperature (degrees), wind speed (mph), and AQI.
            Random random = new Random();
            float temperature = random.Next(-30, 110); // Random temperature between -30 and 110 degrees Fahrenheit.
            float windSpeed = random.Next(0, 100); // Random wind speed between 0 and 100 mph.
            int airQualityIndex = random.Next(0, 500); // Random AQI between 0 (Good) and 500 (Hazardous).

            NotifyObservers(temperature, windSpeed, airQualityIndex);
        }
    }

   
}
