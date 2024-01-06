namespace OpenWeatherAPI
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// A coordinate.
    /// </summary>
    public class Coord
    {
        #region Properties

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
        /// Alias to get the latitude.
        /// </summary>
        ///
        /// <value>
        /// The latitude.
        /// </value>
        public double Latitude
        {
            get { return Lat; }
        }

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
        /// Alias to get the longitude.
        /// </summary>
        ///
        /// <value>
        /// The longitude.
        /// </value>
        public double Longitude
        {
            get { return Lon; }
        }

        #endregion Properties
    }
}
