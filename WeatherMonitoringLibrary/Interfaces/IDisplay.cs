namespace WeatherMonitoringLibrary.Interfaces
{
    /// <summary>
    /// The IDisplay interface defines a method for displaying weather data.
    /// Name: Avinash Nagaiah
    /// </summary>
    public interface IDisplay
    {
        void Display(float temperature, float windSpeed, int airQualityIndex);
    }
}
