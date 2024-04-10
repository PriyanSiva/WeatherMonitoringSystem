﻿// WeatherStation.cs
namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Factory class for creating different types of displays.
    /// </summary>
    public static class WeatherStation
    {
        // Create and return a CurrentConditionsDisplay
        public static CurrentConditionsDisplay CreateCurrentConditionsDisplay(WeatherData weatherData)
        {
            return new CurrentConditionsDisplay(weatherData);
        }

        // Create and return a StatisticsDisplay
        public static StatisticsDisplay CreateStatisticsDisplay(WeatherData weatherData)
        {
            return new StatisticsDisplay(weatherData);
        }

        // Create and return a ForecastDisplay
        public static ForecastDisplay CreateForecastDisplay(WeatherData weatherData)
        {
            return new ForecastDisplay(weatherData);
        }
    }
}