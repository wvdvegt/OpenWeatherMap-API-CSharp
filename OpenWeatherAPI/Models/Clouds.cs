namespace OpenWeatherAPI
{
	using System;
	using System.ComponentModel;
	using System.Text.Json.Serialization;

	/// <summary>
	/// A clouds.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Clouds
    {
        #region Properties

        /// <summary>
        /// Gets or sets all.
        /// </summary>
        ///
        /// <value>
        /// all.
        /// </value>
        [JsonPropertyName("all")]
        [Units("Cloudiness", "%")]
        public int All { get; set; }

        #endregion Properties
    }
}
