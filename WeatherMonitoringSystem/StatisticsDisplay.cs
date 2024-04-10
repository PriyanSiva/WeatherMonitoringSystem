namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Concrete observer that displays weather statistics.
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        private double maxTemperature = 35;
        private double minTemperature = 0;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this); 
        }

        // Update statistics based on temperature
        public void Update(double temperature)
        {
            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }
            if (temperature < minTemperature)
            {
                minTemperature = temperature;
            }

            Display(); 
        }

        // Display weather statistics
        public void Display()
        {
            Console.WriteLine("------");
            Console.WriteLine($"Maximum Temperature: {maxTemperature}°C");
            Console.WriteLine($"Minimum Temperature: {minTemperature}°C");
            Console.WriteLine("------");
        }
    }
}
