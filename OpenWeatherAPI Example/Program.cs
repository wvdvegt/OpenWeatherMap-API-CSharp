using System;
using System.Threading.Tasks;
using OpenWeatherAPI;
using Microsoft.Extensions.Configuration;

namespace OpenWeatherAPI_Example
{
	class Program
	{
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
			var results = await client.QueryAsync(city);

			Console.WriteLine($"The temperature in {city} is {results.Main.Temperature.CelsiusCurrent} °C. There is {results.Wind.SpeedMetersPerSecond} m/s wind in the {results.Wind.Direction} direction.");

			Console.ReadLine();
		}
	}
}
