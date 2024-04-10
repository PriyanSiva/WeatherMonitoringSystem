namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Concrete observer that displays a weather forecast.
    /// </summary>

    public class ForecastDisplay : IDisplay
    {
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this); 
        }

        // Display weather forecast
        public void Display()
        {
        }

        // Overloaded Display method to accept forecast data
        public void Display(string forecast)
        {
            Console.WriteLine($"Forecast: {forecast}");
        }
    }
}
