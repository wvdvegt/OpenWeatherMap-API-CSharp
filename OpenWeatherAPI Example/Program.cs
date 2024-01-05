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
			QueryResponse query = await client.QueryAsync(city);

			Console.WriteLine($"The temperature in {query.Name} ({query.Sys.Country}) is currently {query.Main.Temperature.CelsiusCurrent} °C. There is {query.Wind.SpeedMetersPerSecond} m/s wind in the {query.Wind.Direction} direction.");

			Console.ReadLine();
		}
	}
}
