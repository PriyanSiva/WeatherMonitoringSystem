namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Concrete observer that displays current weather conditions.
    /// It also serves as a decorator to add additional information.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        private double temperature;
        private double humidity;
        private WeatherData weatherData;

        // Current weather conditions
        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this); 
        }

        // Update weather conditions
        public void Update(double temperature, double humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display(); 
        }

        // Display current weather conditions
        public void Display()
        {
            Console.WriteLine($"Current Temperature: {temperature}°C");
            Console.WriteLine($"Current Humidity: {humidity}% humidity");
        }
    }
}
