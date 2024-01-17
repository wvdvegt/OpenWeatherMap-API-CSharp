namespace OpenWeatherAPI
{
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;
	using System.Text.Json;
    using System.Text.Json.Serialization;

	/// <summary>
	/// A geo response.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class GeoResponse
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
        /// Gets or sets the latitude.
        /// </summary>
        ///
        /// <value>
        /// The latitude.
        /// </value>
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        ///
        /// <value>
        /// The longitude.
        /// </value>
        [JsonPropertyName("lon")]
        public double Lon { get; set; }

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
        /// Gets or sets the state.
        /// </summary>
        ///
        /// <value>
        /// The state.
        /// </value>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets a value indicating whether the valid request.
        /// </summary>
        ///
        /// <value>
        /// True if valid request, false if not.
        /// </value>
        public bool ValidRequest
        {
            get { return true; }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Gets full geo data.
        /// </summary>
        ///
        /// <param name="jsonResponse"> The JSON response. </param>
        ///
        /// <returns>
        /// The full geo data.
        /// </returns>
        public static GeoResponse GetFullGeoData(string jsonResponse)
        {
            return JsonSerializer.Deserialize<List<GeoResponse>>(jsonResponse).First();
        }

        /// <summary>
        /// Gets full geo data Items.
        /// </summary>
        ///
        /// <param name="jsonResponse"> The JSON response. </param>
        ///
        /// <returns>
        /// The full geo data Items.
        /// </returns>
        public static List<GeoResponse> GetFullGeoDataList(string jsonResponse)
        {
            return JsonSerializer.Deserialize<List<GeoResponse>>(jsonResponse).ToList();
        }

        #endregion Methods
    }
}
