namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Singleton class responsible for collecting weather data and notifying observers.
    /// </summary>
    public sealed class WeatherData
    {
        private static readonly WeatherData instance = new WeatherData();
        private List<IDisplay> observers;
        private Random random;

        // Singleton instance
        public static WeatherData Instance
        {
            get { return instance; }
        }

        private WeatherData()
        {
            observers = new List<IDisplay>();
            random = new Random();
        }

        // Attach an observer
        public void Attach(IDisplay observer)
        {
            observers.Add(observer);
        }

        // Detach an observer
        public void Detach(IDisplay observer)
        {
            observers.Remove(observer);
        }

        // Notify all observers when weather data changes
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Display();
            }
        }

        // Simulate weather data change (for demonstration)
        public void MeasurementsChanged()
        {
            // Generate random weather data
            double temperature = random.Next(0, 35);
            double humidity = random.Next(0, 100);

            // Update weather data
            SetMeasurements(temperature, humidity);
        }

        // Set weather data
        public void SetMeasurements(double temperature, double humidity)
        {
            // Set weather data here
            // For simplicity, just printing the data
            Console.WriteLine("------");
            Console.WriteLine($"Weather Data Updated");
            Console.WriteLine($"Temperature = {temperature}");
            Console.WriteLine($"Humidity = {humidity}");
            Console.WriteLine("------");
            // Notify observers
            NotifyObservers();
        }
    }
}
