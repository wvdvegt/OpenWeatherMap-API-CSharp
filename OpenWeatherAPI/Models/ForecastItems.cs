namespace OpenWeatherAPI
{
	using System.Collections.Generic;
	using System.ComponentModel;

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class ForecastItems : List<ForecastItem>
	{
	}
}
