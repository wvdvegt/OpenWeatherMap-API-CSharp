using OpenWeatherAPI;

namespace OpenWeatherAPI_App
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		OpenWeatherApiClient client;

		private void Form1_Load(object sender, EventArgs e)
		{
			//! original code:	https://github.com/swiftyspiffy/OpenWeatherMap-API-CSharp.git
			//! forked to:		https://github.com/wvdvegt/OpenWeatherMap-API-CSharp/settings
			//
			client = new OpenWeatherApiClient(Program.config["apikey"]);

			Console.WriteLine("OpenWeatherAPI Example Application");
			Console.WriteLine();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			string city = "Stein,NL";

			Console.WriteLine($"Fetching weather data for '{city}'");
			WeatherResponse weather = await client.WeatherAsync(city);

			if (weather != null)
			{
				propertyGrid1.SelectedObject = weather;

				//Console.WriteLine($"The temperature in {weather.Name} ({weather.Sys.Country}) is currently {weather.Main.Temp.AsCelsius(2)} °C. There is {weather.Wind.SpeedMetersPerSecond} m/s wind in the {weather.Wind.Direction.AsShortDirection("-")} direction.");
			}

			//Console.WriteLine($"Fetching 5 days forecast weather data for '{city}'");
			//ForecastResponse forecast = await client.ForecastAsync(city);

			//Console.WriteLine($"http://openweathermap.org/img/w/{weather.Weather.First().Icon}.png");

			//Console.ReadLine();
		}
	}
}
