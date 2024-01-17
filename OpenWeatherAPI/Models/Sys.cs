namespace OpenWeatherAPI
{
	using System;
	using System.ComponentModel;
	using System.Text.Json.Serialization;

	/// <summary>
	/// Sys.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Sys
	{
		#region Properties

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
		/// Gets or sets the identifier.
		/// </summary>
		///
		/// <value>
		/// The identifier.
		/// </value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the Date/Time of the sunrise.
		/// </summary>
		///
		/// <value>
		/// The sunrise.
		/// </value>
		[JsonPropertyName("sunrise")]
		[JsonConverter(typeof(UnixDateToDateTimeConverter))]
		public DateTime Sunrise { get; set; }

		/// <summary>
		/// Gets or sets the Date/Time of the sunset.
		/// </summary>
		///
		/// <value>
		/// The sunset.
		/// </value>
		[JsonPropertyName("sunset")]
		[JsonConverter(typeof(UnixDateToDateTimeConverter))]
		public DateTime Sunset { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		///
		/// <value>
		/// The type.
		/// </value>
		[JsonPropertyName("type")]
		public int Type { get; set; }

		#endregion Properties
	}
}
