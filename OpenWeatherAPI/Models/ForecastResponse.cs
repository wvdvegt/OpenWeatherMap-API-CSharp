namespace OpenWeatherAPI
{
	using System.ComponentModel;
	using System.Text.Json;
    using System.Text.Json.Serialization;

	/// <summary>
	/// A forecast response.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class ForecastResponse
    {
        #region Properties

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        ///
        /// <value>
        /// The city.
        /// </value>
        [JsonPropertyName("city")]
        public City City { get; set; }

        /// <summary>
        /// Gets or sets the number of forecast items.
        /// </summary>
        /// </summary>
        ///
        /// <value>
        /// The count.
        /// </value>
        [JsonPropertyName("cnt")]
        public int Cnt { get; set; }

        /// <summary>
        /// Internal Parameter.
        /// </summary>
        ///
        /// <value>
        /// Internal Parameter.
        /// </value>
        [JsonPropertyName("cod")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Cod { get; set; }

        /// <summary>
        /// Gets or sets the Items.
        /// </summary>
        ///
        /// <value>
        /// The Items.
        /// </value>
        [JsonPropertyName("list")]
        public ForecastItems Items { get; set; }

        /// <summary>
        /// Internal Parameter.
        /// </summary>
        ///
        /// <value>
        /// Internal Parameter.
        /// </value>
        [JsonPropertyName("message")]
        public int Message { get; set; }

        /// <summary>
        /// Gets a value indicating whether the valid request.
        /// </summary>
        ///
        /// <value>
        /// True if valid request, false if not.
        /// </value>
        public bool ValidRequest
        {
            get
            {
                return Cod == 200;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Gets full weather data.
        /// </summary>
        ///
        /// <param name="jsonResponse"> The JSON response. </param>
        ///
        /// <returns>
        /// The full weather data.
        /// </returns>
        public static ForecastResponse GetForecastData(string jsonResponse)
        {
            return JsonSerializer.Deserialize<ForecastResponse>(jsonResponse);
        }

        #endregion Methods
    }
}
