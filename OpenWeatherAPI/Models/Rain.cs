
namespace OpenWeatherAPI
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// A rain.
    /// </summary>
    public partial class Rain
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
        [Units("Rain Volume", "mm")]
        public double H1 { get; set; }

        /// <summary>
        /// Gets or sets the h 3.
        /// </summary>
        ///
        /// <value>
        /// The h 3.
        /// </value>
        [JsonPropertyName("3h")]
        [Units("Rain Volume", "mm")]
        public double H3 { get; set; }

        #endregion Properties
    }
}
