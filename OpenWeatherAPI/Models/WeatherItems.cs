namespace OpenWeatherAPI
{
    using System.Collections.Generic;
	using System.ComponentModel;

	/// <summary>
	/// A weathers.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class WeatherItems : List<Weather>
    {
    }
}
