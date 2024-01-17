namespace OpenWeatherAPI
{
	using System.ComponentModel;
	using System.Text.Json.Serialization;

	/// <summary>
	/// Sys.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class SysPod
	{
		#region Properties

		/// <summary>
		/// Gets or sets the part of the day: n(ight) or d(ay).
		/// </summary>
		///
		/// <value>
		/// The type.
		/// </value>		
		[JsonPropertyName("pod")]
		public char Pod { get; set; }

		#endregion Properties
	}
}
