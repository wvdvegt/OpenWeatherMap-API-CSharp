namespace OpenWeatherAPI
{
    using System;
	using System.ComponentModel;
	using System.Text.Json.Serialization;

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class ForecastItem
    {
        #region Properties

        /// <summary>
        /// Gets or sets the clouds.
        /// </summary>
        ///
        /// <value>
        /// The clouds.
        /// </value>
        [JsonPropertyName("clouds")]
        public Clouds Clouds { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the dt.
        /// </summary>
        ///
        /// <value>
        /// The dt.
        /// </value>
        [JsonPropertyName("dt")]
        [JsonConverter(typeof(UnixDateToDateTimeConverter))]
        public DateTime Dt { get; set; }

        /// <summary>
        /// Get of sets the Time of data forecasted, ISO, UTC.
        /// </summary>
        ///
        /// <value>
        /// The dt text.
        /// </value>
        [JsonPropertyName("dt_txt")]
        public String dt_txt { get; set; }

        /// <summary>
        /// Gets or sets the main.
        /// </summary>
        ///
        /// <value>
        /// The main.
        /// </value>
        [JsonPropertyName("main")]
        public Main Main { get; set; }

        /// <summary>
        /// Gets or sets the Probability of precipitation.
        /// </summary>
        ///
        /// <value>
        /// The pop.
        /// </value>
        [JsonPropertyName("pop")]
        public double Pop { get; set; }

        /// <summary>
        /// Gets or sets the sys data (only contains pod parameter).
        /// </summary>
        ///
        /// <value>
        /// The sys data.
        /// </value>
        [JsonPropertyName("sys")]
        public SysPod Sys { get; set; }

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
        ///
        /// <value>
        /// The visibility.
        /// </value>
        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        /// <summary>
        /// Gets or sets the weather forecast items.
        /// </summary>
        ///
        /// <value>
        /// The list of weather forecasts.
        /// </value>
        [JsonPropertyName("weather")]
        public WeatherItems WeatherItems { get; set; }

        /// <summary>
        /// Gets or sets the wind.
        /// </summary>
        ///
        /// <value>
        /// The wind.
        /// </value>
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }

        #endregion Properties
    }
}
