using Newtonsoft.Json.Linq;
using System;
using System.Globalization;

namespace OpenWeatherAPI
{
	public partial class Main
	{
		public TemperatureObj Temperature { get; }

		public double Pressure { get; }

		public double Humidity { get; }

		public double SeaLevelAtm { get; }

		public double GroundLevelAtm { get; }

		public Main(JToken mainData)
		{
			if (mainData is null)
				throw new System.ArgumentNullException(nameof(mainData));

			Temperature = new TemperatureObj(
								mainData.SelectToken("temp").Value<Double>(),
								mainData.SelectToken("temp_min").Value<Double>(),
								mainData.SelectToken("temp_max").Value<Double>());

			Pressure = mainData.SelectToken("pressure").Value<Double>();
			Humidity = mainData.SelectToken("humidity").Value<Double>();
			if (mainData.SelectToken("sea_level") != null)
				SeaLevelAtm = mainData.SelectToken("sea_level").Value<Double>();
			if (mainData.SelectToken("grnd_level") != null)
				GroundLevelAtm = mainData.SelectToken("grnd_level").Value<Double>();
		}
	}
}
