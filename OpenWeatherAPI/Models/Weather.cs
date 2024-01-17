namespace OpenWeatherAPI
{
    using System;
	using System.ComponentModel;
	using System.Text.Json.Serialization;

	/// <summary>
	/// A weather.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Weather
    {
        #region Properties

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        ///
        /// <value>
        /// The description.
        /// </value>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        ///
        /// <value>
        /// The icon.
        /// </value>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets URI of the icon.
        /// </summary>
        ///
        /// <value>
        /// The icon URI.
        /// </value>
        public Uri IconUri
        {
            get
            {
                return new Uri($"http://openweathermap.org/img/w/{Icon}.png");
            }
        }

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
        /// Gets or sets the main.
        /// </summary>
        ///
        /// <value>
        /// The main.
        /// </value>
        [JsonPropertyName("main")]
        public string Main { get; set; }

        #endregion Properties
    }
}
