using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace OpenWeatherAPI
{
	public class QueryResponse
	{
		public bool ValidRequest { get; }
		public Coordinates Coordinates { get; }
		public List<Weather> WeatherList { get; } = new List<Weather>();
		public string Base { get; }
		public Main Main { get; }
		public double Visibility { get; }
		public Wind Wind { get; }
		public Rain Rain { get; }
		public Snow Snow { get; }
		public Clouds Clouds { get; }
		public Sys Sys { get; }
		public int ID { get; }
		public string Name { get; }
		public int Cod { get; }
		public int Timezone { get; }

		public QueryResponse(string jsonResponse)
		{
			//! Using NewtonSoft.Json.
			FullWeatherData welcome = JsonConvert.DeserializeObject<FullWeatherData>(jsonResponse);

			//! Using System.Text.Json.
			FullWeatherData weatherForecast = System.Text.Json.JsonSerializer.Deserialize<FullWeatherData>(jsonResponse);

			//! Manual Parsong using NewtonSoft.Json.
			var jsonData = JObject.Parse(jsonResponse);

			if (jsonData.SelectToken("cod").ToString() == "200")
			{
				ValidRequest = true;
				Coordinates = new Coordinates(jsonData.SelectToken("coord"));
				foreach (JToken weather in jsonData.SelectToken("weather"))
					WeatherList.Add(new Weather(weather));
				Base = jsonData.SelectToken("base").ToString();
				Main = new Main(jsonData.SelectToken("main"));
				if (jsonData.SelectToken("visibility") != null)
					Visibility = jsonData.SelectToken("visibility").Value<Double>();
				Wind = new Wind(jsonData.SelectToken("wind"));
				if (jsonData.SelectToken("rain") != null)
					Rain = new Rain(jsonData.SelectToken("rain"));
				if (jsonData.SelectToken("snow") != null)
					Snow = new Snow(jsonData.SelectToken("snow"));
				Clouds = new Clouds(jsonData.SelectToken("clouds"));
				Sys = new Sys(jsonData.SelectToken("sys"));
				ID = jsonData.SelectToken("id").Value<int>();
				Name = jsonData.SelectToken("name").ToString();
				Cod = jsonData.SelectToken("cod").Value<int>();
				Timezone = jsonData.SelectToken("timezone").Value<int>();
			}
			else
			{
				ValidRequest = false;
			}
		}
	}
}
