namespace OpenWeatherAPI
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An unix date to date time converter.
    /// </summary>
    public class UnixDateToDateTimeConverter : JsonConverter<DateTime>
    {
        #region Methods

        /// <summary>
        /// Reads and converts the JSON to type <typeparamref name="T" />.
        /// </summary>
        ///
        /// <param name="reader">  [in,out] The reader. </param>
        /// <param name="type">    The type to convert. </param>
        /// <param name="options"> An object that specifies serialization options to use. </param>
        ///
        /// <returns>
        /// The converted value.
        /// </returns>
        public override DateTime Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                return ConvertUnixToDateTime(reader.GetDouble());
            }

            // fallback to default handling
            return new DateTime();
        }

        /// <summary>
        /// Writes a specified value as JSON.
        /// </summary>
        ///
        /// <param name="writer">  The writer to write to. </param>
        /// <param name="value">   The value to convert to JSON. </param>
        /// <param name="options"> An object that specifies serialization options to use. </param>
        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert unix to date time.
        /// </summary>
        ///
        /// <param name="unixTime"> The unix time. </param>
        ///
        /// <returns>
        /// The unix converted to date time.
        /// </returns>
        private DateTime ConvertUnixToDateTime(double unixTime)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return dt.AddSeconds(unixTime).ToLocalTime();
        }

        #endregion Methods
    }
}
