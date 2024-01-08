namespace OpenWeatherAPI_Example
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Configuration;

    using OpenWeatherAPI;

    /// <summary>
    /// A program.
    /// </summary>
    class Program
    {
        #region Methods

        /// <summary>
        /// Main entry-point for this application.
        /// </summary>
        ///
        /// <param name="args"> An array of command-line argument strings. </param>
        ///
        /// <returns>
        /// A Task.
        /// </returns>
        static async Task Main(string[] args)
        {
            //! See:			https://swharden.com/blog/2021-10-09-console-secrets
            IConfigurationRoot config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

            //! original code:	https://github.com/swiftyspiffy/OpenWeatherMap-API-CSharp.git
            //! forked to:		https://github.com/wvdvegt/OpenWeatherMap-API-CSharp/settings
            //
            var client = new OpenWeatherApiClient(config["apikey"]);

            Console.WriteLine("OpenWeatherAPI Example Application");
            Console.WriteLine();

            Console.WriteLine("Enter city to get weather data for:");
            var city = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Fetching weather data for '{city}'");
            WeatherResponse weather = await client.WeatherAsync(city);

            if (weather != null)
            {
                Console.WriteLine($"The temperature in {weather.Name} ({weather.Sys.Country}) is currently {weather.Main.Temp.AsCelsius(2)} °C. There is {weather.Wind.SpeedMetersPerSecond} m/s wind in the {weather.Wind.Direction.AsShortDirection("-")} direction.");
            }

            Console.WriteLine($"Fetching 5 days forecast weather data for '{city}'");
            ForecastResponse forecast = await client.ForecastAsync(city);

            Console.WriteLine($"http://openweathermap.org/img/w/{weather.Weather.First().Icon}.png");

            Console.ReadLine();
        }

        #endregion Methods
    }
}
