using System;
using System.Globalization;
using Newtonsoft.Json.Linq;

namespace OpenWeatherAPI
{
	public class GeoResponse
	{
		public bool ValidRequest { get; }
		public double Lat { get; }
		public double Lon { get; }

		public GeoResponse(string jsonResponse)
		{
			var jsonData = JArray.Parse(jsonResponse);
			Lat = jsonData[0].SelectToken("lat").Value<Double>();
			Lon = jsonData[0].SelectToken("lon").Value<Double>();
			ValidRequest = true;
		}
	}
}
