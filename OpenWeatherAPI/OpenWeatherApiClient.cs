namespace OpenWeatherAPI
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// An open weather API client.
    /// </summary>
    public class OpenWeatherApiClient : IDisposable
    {
        #region Fields

        /// <summary>
        /// (Immutable) The API key.
        /// </summary>
        private readonly string _apiKey;

        /// <summary>
        /// (Immutable) The HTTP client.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// (Immutable) True to use HTTPS.
        /// </summary>
        private readonly bool _useHttps;

        /// <summary>
        /// True if disposed.
        /// </summary>
        private bool _disposed;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <param name="apiKey">   The API key. </param>
        /// <param name="useHttps"> (Optional) True to use HTTPS. </param>
        public OpenWeatherApiClient(string apiKey, bool useHttps = false)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
            _useHttps = useHttps;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged
        /// resources.
        /// </summary>
        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);

            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// (This method is obsolete) forecasts.
        /// </summary>
        ///
        /// <param name="queryString"> The query string. </param>
        ///
        /// <returns>
        /// A ForecastResponse.
        /// </returns>
        [Obsolete("Use Async version wherever possible.")]
        public ForecastResponse Forecast(string queryString)
        {
            return Task.Run(async () => await ForecastAsync(queryString).ConfigureAwait(false)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries an asynchronous.
        /// </summary>
        ///
        /// <param name="queryString"> . </param>
        ///
        /// <returns>
        /// Returns null if the query is invalid.
        /// </returns>
        public async Task<ForecastResponse> ForecastAsync(string queryString)
        {
            var jsonResponse = await _httpClient.GetStringAsync(GenerateForecastRequestUrl(queryString).Result).ConfigureAwait(false);
            var query = ForecastResponse.GetForecastData(jsonResponse);

            return query.ValidRequest ? query : null;
        }

        /// <summary>
        /// (This method is obsolete) geolocates.
        /// </summary>
        ///
        /// <param name="queryString"> The query string. </param>
        ///
        /// <returns>
        /// A GeoResponse.
        /// </returns>
        [Obsolete("Use Async version wherever possible.")]
        public GeoResponse Geolocate(string queryString)
        {
            return Task.Run(async () => await GeolocateAsync(queryString).ConfigureAwait(false)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Geolocate asynchronous.
        /// </summary>
        ///
        /// <param name="queryString"> The query string. </param>
        ///
        /// <returns>
        /// The geolocate.
        /// </returns>
        public async Task<GeoResponse> GeolocateAsync(string queryString)
        {
            string scheme = "http";
            if (_useHttps)
                scheme = "https";

            var jsonResponse = await _httpClient
                .GetStringAsync(
                    new Uri($"{scheme}://api.openweathermap.org/geo/1.0/direct?q={queryString}&limit={1}&appid={_apiKey}"))
                .ConfigureAwait(false);

            return GeoResponse.GetFullGeoData(jsonResponse);
        }

        /// <summary>
        /// (This method is obsolete) weathers.
        /// </summary>
        ///
        /// <param name="queryString"> The query string. </param>
        ///
        /// <returns>
        /// A WeatherResponse.
        /// </returns>
        [Obsolete("Use Async version wherever possible.")]
        public WeatherResponse Weather(string queryString)
        {
            return Task.Run(async () => await WeatherAsync(queryString).ConfigureAwait(false)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries an asynchronous.
        /// </summary>
        ///
        /// <param name="queryString"> . </param>
        ///
        /// <returns>
        /// Returns null if the query is invalid.
        /// </returns>
        public async Task<WeatherResponse> WeatherAsync(string queryString)
        {
            var jsonResponse = await _httpClient.GetStringAsync(GenerateWeatherRequestUrl(queryString).Result).ConfigureAwait(false);
            var query = WeatherResponse.GetWeatherData(jsonResponse);

            return query.ValidRequest ? query : null;
        }

        /// <summary>
        /// Releases the unmanaged resources used by the OpenWeatherApiClient and optionally releases the
        /// managed resources.
        /// </summary>
        ///
        /// <param name="disposing"> True to release both managed and unmanaged resources; false to
        /// 						 release only unmanaged resources. </param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // dispose managed state (managed objects).
            }

            // free unmanaged resources (unmanaged objects) and override a finalizer below.
            // set large fields to null.

            _httpClient.Dispose();

            _disposed = true;
        }

        /// <summary>
        /// Generates a request URL.
        /// 
        /// See https://openweathermap.org/forecast5.
        /// </summary>
        ///
        /// <param name="queryString"> The query string. </param>
        ///
        /// <returns>
        /// The request URL.
        /// </returns>
        private async Task<Uri> GenerateForecastRequestUrl(string queryString)
        {
            var geo = await GeolocateAsync(queryString).ConfigureAwait(false);

            string scheme = "http";
            if (_useHttps)
                scheme = "https";
            return new Uri($"{scheme}://api.openweathermap.org/data/2.5/forecast?appid={_apiKey}&lat={geo.Lat}&lon={geo.Lon}");
        }

        /// <summary>
        /// Generates a request URL.
        /// 
        /// See https://openweathermap.org/current.
        /// </summary>
        ///
        /// <param name="queryString"> The query string. </param>
        ///
        /// <returns>
        /// The request URL.
        /// </returns>
        private async Task<Uri> GenerateWeatherRequestUrl(string queryString)
        {
            var geo = await GeolocateAsync(queryString).ConfigureAwait(false);

            string scheme = "http";
            if (_useHttps)
                scheme = "https";
            return new Uri($"{scheme}://api.openweathermap.org/data/2.5/weather?appid={_apiKey}&lat={geo.Lat}&lon={geo.Lon}");
        }

        #endregion Methods
    }
}
