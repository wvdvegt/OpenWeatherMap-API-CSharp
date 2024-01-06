namespace OpenWeatherAPI
{
    using System;

    /// <summary>
    /// An extension methods.
    /// </summary>
    public static class ExtensionMethods
    {
        #region Methods

        /// <summary>
        /// A double extension method that converts this object to the celsius.
        /// </summary>
        ///
        /// <param name="kelvin">   The kelvin to act on. </param>
        /// <param name="decimals"> (Optional) The decimals. </param>
        ///
        /// <returns>
        /// A double.
        /// </returns>
        public static double AsCelsius(this double kelvin, int decimals = 3)
        {
            return Math.Round(kelvin - 273.15, decimals);
        }

        /// <summary>
        /// A double extension method that converts this object to a fahrenheit.
        /// </summary>
        ///
        /// <param name="kelvin">   The kelvin to act on. </param>
        /// <param name="decimals"> (Optional) The decimals. </param>
        ///
        /// <returns>
        /// A double.
        /// </returns>
        public static double AsFahrenheit(this double kelvin, int decimals = 3)
        {
            double Celsius = kelvin - 273.15;
            return Math.Round(((9.0 / 5.0) * Celsius) + 32, decimals);
        }

        /// <summary>
        /// A double extension method that converts this object to a kelvin.
        /// </summary>
        ///
        /// <param name="kelvin">   The kelvin to act on. </param>
        /// <param name="decimals"> (Optional) The decimals. </param>
        ///
        /// <returns>
        /// A double.
        /// </returns>
        public static double AsKelvin(this double kelvin, int decimals = 3)
        {
            return Math.Round(kelvin, decimals);
        }

        /// <summary>
        /// A double extension method that converts this object to a reaumur.
        /// </summary>
        ///
        /// <param name="kelvin">   The kelvin to act on. </param>
        /// <param name="decimals"> (Optional) The decimals. </param>
        ///
        /// <returns>
        /// A double.
        /// </returns>
        public static double AsReaumur(this double kelvin, int decimals = 3)
        {
            double Celsius = kelvin - 273.15;
            return Math.Round(Celsius * 5.0 / 4.0, decimals);
        }

        #endregion Methods
    }
}
