namespace OpenWeatherAPI
{
	using System;
	using System.ComponentModel;
	using System.Text.Json.Serialization;

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class City
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		///
		/// <value>
		/// The identifier.
		/// </value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		///
		/// <value>
		/// The name.
		/// </value>
		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the coordinate.
		/// </summary>
		///
		/// <value>
		/// The coordinate.
		/// </value>
		[JsonPropertyName("coord")]
		public Coord Coord { get; set; }


		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		///
		/// <value>
		/// The country.
		/// </value>
		[JsonPropertyName("country")]
		public string Country { get; set; }

		/// <summary>
		/// Gets or sets the population.
		/// </summary>
		///
		/// <value>
		/// The population.
		/// </value>
		[JsonPropertyName("population")]
		public int Population { get; set; }

		[JsonPropertyName("timezone")]
		public int Timezone { get; set; }

		/// <summary>
		/// Gets or sets the sunrise.
		/// </summary>
		///
		/// <value>
		/// The sunrise.
		/// </value>
		[JsonPropertyName("sunrise")]
		[JsonConverter(typeof(UnixDateToDateTimeConverter))]
		public DateTime Sunrise { get; set; }

		/// <summary>
		/// Gets or sets the sunset.
		/// </summary>
		///
		/// <value>
		/// The sunset.
		/// </value>
		[JsonPropertyName("sunset")]
		[JsonConverter(typeof(UnixDateToDateTimeConverter))]
		public DateTime Sunset { get; set; }
	}
}
