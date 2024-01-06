namespace OpenWeatherAPI
{
    using System;

    /// <summary>
    /// A temperature object.
    /// </summary>
    public class TemperatureObj
    {
        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <param name="temp">		 The temporary. </param>
        /// <param name="min">		 The minimum. </param>
        /// <param name="max">		 The maximum. </param>
        /// <param name="feelslike"> The feelslike. </param>
        public TemperatureObj(double temp, double min, double max, double feelslike)
        {
            KelvinCurrent = temp;
            KelvinMaximum = max;
            KelvinMinimum = min;
            KelvinFeelsLike = feelslike;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the Celsius current.
        /// </summary>
        ///
        /// <value>
        /// The celsius current.
        /// </value>
        [Units("Celsius", "°C")]
        public double CelsiusCurrent
        {
            get { return ConvertKelvinToCelsius(KelvinCurrent); }
        }

        /// <summary>
        /// Gets the Celsius feels like.
        /// </summary>
        ///
        /// <value>
        /// The Celsius feels like.
        /// </value>
        [Units("Celsius", "°C")]
        public double CelsiusFeelsLike
        {
            get { return ConvertKelvinToCelsius(KelvinFeelsLike); }
        }

        /// <summary>
        /// Gets the Celsius maximum.
        /// </summary>
        ///
        /// <value>
        /// The Celsius maximum.
        /// </value>
        [Units("Celsius", "°C")]
        public double CelsiusMaximum
        {
            get { return ConvertKelvinToCelsius(KelvinMaximum); }
        }

        /// <summary>
        /// Gets the Celsius minimum.
        /// </summary>
        ///
        /// <value>
        /// The Celsius minimum.
        /// </value>
        [Units("Celsius", "°C")]
        public double CelsiusMinimum
        {
            get { return ConvertKelvinToCelsius(KelvinMinimum); }
        }

        /// <summary>
        /// Gets the Fahrenheit current.
        /// </summary>
        ///
        /// <value>
        /// The Fahrenheit current.
        /// </value>
        [Units("Fahrenheit", "F")]
        public double FahrenheitCurrent
        {
            get { return ConvertCelsiusToFahrenheit(CelsiusCurrent); }
        }

        /// <summary>
        /// Gets the Fahrenheit feels like.
        /// </summary>
        ///
        /// <value>
        /// The Fahrenheit feels like.
        /// </value>
        [Units("Fahrenheit", "F")]
        public double FahrenheitFeelsLike
        {
            get { return ConvertCelsiusToFahrenheit(CelsiusFeelsLike); }
        }

        /// <summary>
        /// Gets the Fahrenheit maximum.
        /// </summary>
        ///
        /// <value>
        /// The Fahrenheit maximum.
        /// </value>
        [Units("Fahrenheit", "F")]
        public double FahrenheitMaximum
        {
            get { return ConvertCelsiusToFahrenheit(CelsiusMaximum); }
        }

        /// <summary>
        /// Gets the Fahrenheit minimum.
        /// </summary>
        ///
        /// <value>
        /// The Fahrenheit minimum.
        /// </value>
        [Units("Fahrenheit", "F")]
        public double FahrenheitMinimum
        {
            get { return ConvertCelsiusToFahrenheit(CelsiusMinimum); }
        }

        /// <summary>
        /// Gets or sets the kelvin current.
        /// </summary>
        ///
        /// <value>
        /// The kelvin current.
        /// </value>
        [Units("Kelvin", "K")]
        public double KelvinCurrent { get; private set; }

        /// <summary>
        /// Gets or sets the kelvin feels like.
        /// </summary>
        ///
        /// <value>
        /// The kelvin feels like.
        /// </value>
        [Units("Kelvin", "K")]
        public double KelvinFeelsLike { get; private set; }

        /// <summary>
        /// Gets or sets the kelvin maximum.
        /// </summary>
        ///
        /// <value>
        /// The kelvin maximum.
        /// </value>
        [Units("Kelvin", "K")]
        public double KelvinMaximum { get; private set; }

        /// <summary>
        /// Gets or sets the kelvin minimum.
        /// </summary>
        ///
        /// <value>
        /// The kelvin minimum.
        /// </value>
        [Units("Kelvin", "K")]
        public double KelvinMinimum { get; private set; }

        /// <summary>
        /// Gets the Réaumur current.
        /// </summary>
        ///
        /// <value>
        /// The Réaumur current.
        /// </value>
        [Units("Réaumur", "°Ré")]
        public double ReaumurCurrent
        {
            get { return ConvertCelsiusToReaumur(KelvinCurrent); }
        }

        /// <summary>
        /// Gets the Réaumur feels like.
        /// </summary>
        ///
        /// <value>
        /// The Réaumur feels like.
        /// </value>
        [Units("Réaumur", "°Ré")]
        public double ReaumurFeelsLike
        {
            get { return ConvertCelsiusToReaumur(KelvinFeelsLike); }
        }

        /// <summary>
        /// Gets the Réaumur maximum.
        /// </summary>
        ///
        /// <value>
        /// The Réaumur maximum.
        /// </value>
        [Units("Réaumur", "°Ré")]
        public double ReaumurMaximum
        {
            get { return ConvertCelsiusToReaumur(KelvinMaximum); }
        }

        /// <summary>
        /// Gets the Réaumur minimum.
        /// </summary>
        ///
        /// <value>
        /// The Réaumur minimum.
        /// </value>
        [Units("Réaumur", "°Ré")]
        public double ReaumurMinimum
        {
            get { return ConvertCelsiusToReaumur(KelvinMinimum); }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Convert Celsius to Fahrenheit.
        /// </summary>
        ///
        /// <param name="celsius"> The Celsius. </param>
        ///
        /// <returns>
        /// The Celsius converted to Fahrenheit.
        /// </returns>
        private static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return Math.Round(((9.0 / 5.0) * celsius) + 32, 3);
        }

        /// <summary>
        /// Convert Celsius to Reaumur.
        /// </summary>
        ///
        /// <param name="celsius"> The Celsius. </param>
        ///
        /// <returns>
        /// The Celsius converted to Reaumur.
        /// </returns>
        private static double ConvertCelsiusToReaumur(double celsius)
        {
            return Math.Round(celsius * 5.0 / 4.0, 3);
        }

        /// <summary>
        /// Convert kelvin to Celsius.
        /// </summary>
        ///
        /// <param name="kelvin"> The Kelvin. </param>
        ///
        /// <returns>
        /// The Kelvin converted to Celsius.
        /// </returns>
        private static double ConvertKelvinToCelsius(double kelvin)
        {
            return Math.Round(kelvin - 273.15, 3);
        }

        #endregion Methods
    }
}
