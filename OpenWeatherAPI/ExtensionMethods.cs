namespace OpenWeatherAPI
{
	using System;
	using System.Linq;

	using static OpenWeatherAPI.Wind;

	using Kelvin = System.Double;

	/// <summary>
	/// An extension methods.
	/// </summary>
	public static class ExtensionMethods
	{
		#region Methods

		/// <summary>
		/// A double extension method that converts this object to the Celsius.
		/// </summary>
		///
		/// <param name="kelvin">   The Kelvin to act on. </param>
		/// <param name="decimals"> (Optional) The decimals. </param>
		///
		/// <returns>
		/// A double.
		/// </returns>
		public static double AsCelsius(this Kelvin kelvin, int decimals = 3)
		{
			return Math.Round(kelvin - 273.15, decimals);
		}

		/// <summary>
		/// A double extension method that converts this object to a Fahrenheit.
		/// </summary>
		///
		/// <param name="kelvin">   The Kelvin to act on. </param>
		/// <param name="decimals"> (Optional) The decimals. </param>
		///
		/// <returns>
		/// A double.
		/// </returns>
		public static double AsFahrenheit(this Kelvin kelvin, int decimals = 3)
		{
			double Celsius = kelvin - 273.15;
			return Math.Round(((9.0 / 5.0) * Celsius) + 32, decimals);
		}

		/// <summary>
		/// A double extension method that converts this object to a Kelvin.
		/// </summary>
		///
		/// <param name="kelvin">   The Kelvin to act on. </param>
		/// <param name="decimals"> (Optional) The decimals. </param>
		///
		/// <returns>
		/// A double.
		/// </returns>
		public static double AsKelvin(this Kelvin kelvin, int decimals = 3)
		{
			return Math.Round(kelvin, decimals);
		}

		/// <summary>
		/// A double extension method that converts this object to Réaumur.
		/// </summary>
		///
		/// <param name="kelvin">   The Kelvin to act on. </param>
		/// <param name="decimals"> (Optional) The decimals. </param>
		///
		/// <returns>
		/// A double.
		/// </returns>
		public static double AsReaumur(this Kelvin kelvin, int decimals = 3)
		{
			double Celsius = kelvin - 273.15;
			return Math.Round(Celsius * 5.0 / 4.0, decimals);
		}

		/// <summary>
		/// A DirectionEnum extension method that converts this object to a direction.
		/// </summary>
		///
		/// <param name="direction"> The direction to act on. </param>
		/// <param name="replace_">  The replace. </param>
		///
		/// <returns>
		/// A string.
		/// </returns>
		public static string AsDirection(this DirectionEnum direction, string replace_)
		{
			return $"{direction}".Replace("_", replace_);
		}

		/// <summary>
		/// A DirectionEnum extension method that converts a direction to a short direction.
		/// </summary>
		///
		/// <param name="direction"> The direction to act on. </param>
		///
		/// <returns>
		/// A string.
		/// </returns>
		public static string AsShortDirection(this DirectionEnum direction, string replace_ = "")
		{
			return string.Join(
				string.Empty,
				$"{direction.AsDirection(replace_)}".Where(p => p.ToString() == p.ToString().ToUpper()));
		}

		#endregion Methods
	}
}
