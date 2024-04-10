namespace WeatherMonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create WeatherData singleton instance
            WeatherData weatherData = WeatherData.Instance;

            // Create different displays using the factory
            CurrentConditionsDisplay currentConditionsDisplay = WeatherStation.CreateCurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = WeatherStation.CreateStatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = WeatherStation.CreateForecastDisplay(weatherData);

            // Weather data changes
            weatherData.MeasurementsChanged();
        }
    }
}
