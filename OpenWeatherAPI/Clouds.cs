using Newtonsoft.Json.Linq;
using System;
using System.Globalization;

namespace OpenWeatherAPI
{
	public class Clouds
	{
		public Clouds(JToken cloudsData)
		{
			if (cloudsData is null)
				throw new System.ArgumentNullException(nameof(cloudsData));


			All = cloudsData.SelectToken("all").Value<Double>();
		}

		public double All { get; }
	}
}
