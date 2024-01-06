namespace OpenWeatherAPI
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A weather response.
    /// </summary>
    public partial class WeatherResponse
    {
        #region Properties

        /// <summary>
        /// Gets or sets the base.
        /// </summary>
        ///
        /// <value>
        /// The base.
        /// </value>
        [JsonPropertyName("base")]
        public string Base { get; set; }

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
        /// Gets or sets the cod.
        /// </summary>
        ///
        /// <value>
        /// The cod.
        /// </value>
        [JsonPropertyName("cod")]
        public int Cod { get; set; }

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
        public Main Main { get; set; }

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
        /// Gets or sets the rain.
        /// </summary>
        ///
        /// <value>
        /// The rain.
        /// </value>
        [JsonPropertyName("rain")]
        public Rain Rain { get; set; }

        /// <summary>
        /// Gets or sets the system.
        /// </summary>
        ///
        /// <value>
        /// The system.
        /// </value>
        [JsonPropertyName("sys")]
        public Sys Sys { get; set; }

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        ///
        /// <value>
        /// The timezone.
        /// </value>
        [JsonPropertyName("timezone")]
        [Units("Timezone Shift", "sec")]
        public int Timezone { get; set; }

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

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
        ///
        /// <value>
        /// The visibility.
        /// </value>
        [JsonPropertyName("visibility")]
        [Units("Visibility", "m")]
        public int Visibility { get; set; }

        /// <summary>
        /// Gets or sets the weather.
        /// </summary>
        ///
        /// <value>
        /// The weather.
        /// </value>
        [JsonPropertyName("weather")]
        public Weather[] Weather { get; set; }

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
        public static WeatherResponse GetFullWeatherData(string jsonResponse)
        {
            return JsonSerializer.Deserialize<WeatherResponse>(jsonResponse);
        }

        #endregion Methods
    }
}
