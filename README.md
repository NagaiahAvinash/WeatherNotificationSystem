# WeatherNotificationSystem
Weather Monitoring System
Overview
This Weather Monitoring System application is a modular development project designed by Avinash Nagaiah for the course "Modular Development" instructed by Professor Brent Riche.

The application simulates a weather monitoring system that collects weather data from a weather station and updates multiple displays when the weather changes. It follows design patterns such as Singleton, Factory, Observer, and Interfaces to achieve modularity, flexibility, and extensibility.

Features:
Singleton Pattern: The WeatherData class is implemented as a Singleton to ensure only one instance exists throughout the application.

Factory Pattern: The WeatherStation class acts as a factory for creating different types of display elements (CurrentConditionsDisplay, StatisticsDisplay, ForecastDisplay).

Observer Pattern: Display elements are registered as observers to the WeatherData Singleton. When weather data changes, observers are notified and update their displays accordingly.

Interfaces Pattern: The IDisplay interface defines a method for displaying weather data, allowing for the implementation of various display types.

How to Use:
Prerequisites:
.NET SDK installed

Running the Application:

Clone this repository to your local machine:
git clone <repository-url>

Navigate to the WeatherMonitoringApp directory:
cd WeatherMonitoringApp

Build the solution:
dotnet build

Run the application:
dotnet run

Sample Output:
Weather Notification 1:
Current Conditions: Temperature=13F, Wind Speed=24mph, AQI=268
Statistics: Avg Temp=13F, Max Temp=13F, Min Temp=13F
Forecast: Air quality is getting worse

Weather Notification 2:
Current Conditions: Temperature=21F, Wind Speed=82mph, AQI=68
Statistics: Avg Temp=17F, Max Temp=21F, Min Temp=13F
Forecast: Air quality is improving

Weather Notification 3:
Current Conditions: Temperature=-17F, Wind Speed=75mph, AQI=390
Statistics: Avg Temp=5.6666665F, Max Temp=21F, Min Temp=-17F
Forecast: Air quality is getting worse

Weather Notification 4:
Current Conditions: Temperature=97F, Wind Speed=61mph, AQI=98
Statistics: Avg Temp=28.5F, Max Temp=97F, Min Temp=-17F
Forecast: Air quality is improving

Weather Notification 5:
Current Conditions: Temperature=44F, Wind Speed=47mph, AQI=294
Statistics: Avg Temp=31.6F, Max Temp=97F, Min Temp=-17F
Forecast: Air quality is getting worse

Credits
Author: Avinash Nagaiah
Professor: Brent Riche
Course: Modular Development
Assignment: Weather Notification System
