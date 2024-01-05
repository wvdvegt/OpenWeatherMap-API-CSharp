using Newtonsoft.Json.Linq;
using System;
using System.Globalization;

namespace OpenWeatherAPI
{
	public class Sys
	{
		public int Type { get; }

		public int ID { get; }

		public double Message { get; }

		public string Country { get; }

		public DateTime Sunrise { get; }

		public DateTime Sunset { get; }

		public Sys(JToken sysData)
		{
			if (sysData is null)
				throw new ArgumentNullException(nameof(sysData));


			if (sysData.SelectToken("type") != null)
				Type = sysData.SelectToken("type").Value<int>();
			if (sysData.SelectToken("id") != null)
				ID = sysData.SelectToken("id").Value<int>();
			if (sysData.SelectToken("message") != null)
				Message =sysData.SelectToken("message").Value<double>();
			Country = sysData.SelectToken("country").ToString();
			Sunrise = ConvertUnixToDateTime(sysData.SelectToken("sunrise").Value<double>());
			Sunset = ConvertUnixToDateTime(sysData.SelectToken("sunset").Value<double>());
		}

		private static DateTime ConvertUnixToDateTime(double unixTime)
		{
			DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			return dt.AddSeconds(unixTime).ToLocalTime();
		}
	}
}
