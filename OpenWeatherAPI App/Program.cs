using Microsoft.Extensions.Configuration;

namespace OpenWeatherAPI_App
{
	internal class Program
	{
		internal static IConfigurationRoot config;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//! See:			https://swharden.com/blog/2021-10-09-console-secrets
			config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}
