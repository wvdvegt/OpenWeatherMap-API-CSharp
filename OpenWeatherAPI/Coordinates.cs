using Newtonsoft.Json.Linq;
using System;
using System.Globalization;

namespace OpenWeatherAPI
{
	public class Coordinates
	{
		public double Longitude { get; }

		public double Latitude { get; }

		public Coordinates(JToken coordinateData)
		{
			if (coordinateData is null)
				throw new System.ArgumentNullException(nameof(coordinateData));

			Longitude = coordinateData.SelectToken("lon").Value<Double>();
			Latitude = coordinateData.SelectToken("lat").Value<Double>();
		}
	}
}
