namespace OpenWeatherAPI
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// A clouds.
    /// </summary>
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
