namespace OpenWeatherAPI
{
	using System.ComponentModel;
	using System.Text.Json.Serialization;

	/// <summary>
	/// A snow.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Snow
    {
        #region Properties

        /// <summary>
        /// Gets or sets the h 1.
        /// </summary>
        ///
        /// <value>
        /// The h 1.
        /// </value>
        [JsonPropertyName("1h")]
        [Units("Snow Volume", "mm")]
        public double H1 { get; set; }

        /// <summary>
        /// Gets or sets the h 2.
        /// </summary>
        ///
        /// <value>
        /// The h 2.
        /// </value>
        [JsonPropertyName("3h")]
        [Units("Snow Volume", "mm")]
        public double H3 { get; set; }

        #endregion Properties
    }
}
