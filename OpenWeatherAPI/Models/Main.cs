
namespace OpenWeatherAPI
{
	using System.ComponentModel;
	using System.Text.Json.Serialization;
	using Kelvin = System.Double;

	/// <summary>
	/// A main.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public partial class Main
	{
		#region Properties

		/// <summary>
		/// Gets or sets the feels like temperature in Kelvin.
		/// </summary>
		///
		/// <value>
		/// The feels like.
		/// </value>
		[JsonPropertyName("feels_like")]
		[Units("Kelvin", "K")]
		public Kelvin FeelsLike { get; set; }

		/// <summary>
		/// Gets or sets the ground level atm.
		/// </summary>
		///
		/// <value>
		/// The ground level atm.
		/// </value>
		[JsonPropertyName("grnd_level")]
		[Units("Pascal", "hPa")]
		public double GroundLevelAtm { get; set; }

		/// <summary>
		/// Gets or sets the humidity.
		/// </summary>
		///
		/// <value>
		/// The humidity.
		/// </value>
		[JsonPropertyName("humidity")]
		[Units("Percentage", "%")]
		public int Humidity { get; set; }

		/// <summary>
		/// Gets or sets the pressure.
		/// </summary>
		///
		/// <value>
		/// The pressure.
		/// </value>
		[JsonPropertyName("pressure")]
		[Units("Pascal", "hPa")]
		public int Pressure { get; set; }

		/// <summary>
		/// Gets or sets the sea level atm.
		/// </summary>
		///
		/// <value>
		/// The sea level atm.
		/// </value>
		[JsonPropertyName("sea_level")]
		[Units("Pascal", "hPa")]
		public double SeaLevelAtm { get; set; }

		/// <summary>
		/// Gets or sets the temporary.
		/// </summary>
		///
		/// <value>
		/// The temporary.
		/// </value>
		[JsonPropertyName("temp")]
		[Units("Kelvin", "K")]
		public double Temp { get; set; }

		/// <summary>
		/// Internal Parameter.
		/// </summary>
		///
		/// <value>
		/// Internal Parameter.
		/// </value>

		[JsonPropertyName("temp_kf")]
		public double Temp_kf { get; set; }

		/// <summary>
		/// Alias for the current temperature in Kelvin.
		/// </summary>
		///
		/// <value>
		/// The temperature.
		/// </value>
		[Units("Kelvin", "K")]
		public Kelvin Temperature
		{
			get { return Temp; }
		}

		/// <summary>
		/// Gets or sets the temporary maximum in Kelvin.
		/// </summary>
		///
		/// <value>
		/// The temporary maximum.
		/// </value>
		[JsonPropertyName("temp_max")]
		[Units("Kelvin", "K")]
		public Kelvin TempMax { get; set; }

		/// <summary>
		/// Gets or sets the temporary minimum in Kelvin.
		/// </summary>
		///
		/// <value>
		/// The temporary minimum.
		/// </value>
		[JsonPropertyName("temp_min")]
		[Units("Kelvin", "K")]
		public Kelvin TempMin { get; set; }

		#endregion Properties
	}
}
