namespace OpenWeatherAPI
{
	using System;
	using System.ComponentModel;
	using System.Linq;
	using System.Text.Json.Serialization;

	/// <summary>
	/// A wind.
	/// </summary>
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Wind
	{
		#region Enumerations

		/// <summary>
		/// Values that represent direction enumeration.
		/// </summary>
		public enum DirectionEnum
		{
			/// <summary>
			/// An enum constant representing the north option.
			/// </summary>
			North,
			/// <summary>
			/// An enum constant representing the north east option.
			/// </summary>
			North_North_East,
			/// <summary>
			/// An enum constant representing the north east option.
			/// </summary>
			North_East,
			/// <summary>
			/// An enum constant representing the east north east option.
			/// </summary>
			East_North_East,
			/// <summary>
			/// An enum constant representing the east option.
			/// </summary>
			East,
			/// <summary>
			/// An enum constant representing the east south east option.
			/// </summary>
			East_South_East,
			/// <summary>
			/// An enum constant representing the south east option.
			/// </summary>
			South_East,
			/// <summary>
			/// An enum constant representing the south east option.
			/// </summary>
			South_South_East,
			/// <summary>
			/// An enum constant representing the south option.
			/// </summary>
			South,
			/// <summary>
			/// An enum constant representing the south west option.
			/// </summary>
			South_South_West,
			/// <summary>
			/// An enum constant representing the south west option.
			/// </summary>
			South_West,
			/// <summary>
			/// An enum constant representing the west south west option.
			/// </summary>
			West_South_West,
			/// <summary>
			/// An enum constant representing the west option.
			/// </summary>
			West,
			/// <summary>
			/// An enum constant representing the west north west option.
			/// </summary>
			West_North_West,
			/// <summary>
			/// An enum constant representing the north west option.
			/// </summary>
			North_West,
			/// <summary>
			/// An enum constant representing the north west option.
			/// </summary>
			North_North_West,
			/// <summary>
			/// An enum constant representing the unknown option.
			/// </summary>
			Unknown,
		}

		#endregion Enumerations

		#region Properties

		/// <summary>
		/// Gets or sets the degrees.
		/// </summary>
		///
		/// <value>
		/// The degrees.
		/// </value>
		[JsonPropertyName("deg")]
		[Units("degrees", "deg")]
		[Description("Wind direction in degree.")]
		public double Deg { get; set; }

		/// <summary>
		/// Gets the degree.
		/// </summary>
		///
		/// <value>
		/// The degree.
		/// </value>
		[Description("Wind direction in degree.")]
		public double Degree
		{
			get { return Deg; }
		}

		/// <summary>
		/// Gets the direction.
		/// </summary>
		///
		/// <value>
		/// The direction.
		/// </value>
		[Description("Wind direction.")]
		public DirectionEnum Direction
		{
			get { return assignDirection(Degree); }
		}

		/// <summary>
		/// Gets the gust.
		/// </summary>
		///
		/// <value>
		/// The gust.
		/// </value>
		[JsonPropertyName("gust")]
		[Units("meter/sec", "m/s")]
		[Description("Gust in meter/sec.")]
		public double Gust { get; }

		/// <summary>
		/// Gets or sets the speed.
		/// </summary>
		///
		/// <value>
		/// The speed.
		/// </value>
		[JsonPropertyName("speed")]
		[Units("meter/sec", "m/s")]
		[Description("Windspeed in meter/sec.")]

		public double Speed { get; set; }

		/// <summary>
		/// Gets the speed feet per second.
		/// </summary>
		///
		/// <value>
		/// The speed feet per second.
		/// </value>
		[Units("feet/sec", "m/s")]
		[Description("Windspeed in feet/sec.")]
		public double SpeedFeetPerSecond
		{
			get { return Speed * 3.28084; }
		}

		/// <summary>
		/// Gets the speed meters per second.
		/// </summary>
		///
		/// <value>
		/// The speed meters per second.
		/// </value>
		[Units("meter/sec", "m/s")]
		[Description("Windspeed in meter/sec.")]
		public double SpeedMetersPerSecond
		{
			get { return Speed; }
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// Direction enum to string.
		/// </summary>
		///
		/// <param name="dir"> The dir. </param>
		///
		/// <returns>
		/// A string.
		/// </returns>
		public static string DirectionEnumToString(DirectionEnum dir)
		{
			switch (dir)
			{
				case DirectionEnum.East:
					return "East";
				case DirectionEnum.East_North_East:
					return "East North-East";
				case DirectionEnum.East_South_East:
					return "East South-East";
				case DirectionEnum.North:
					return "North";
				case DirectionEnum.North_East:
					return "North East";
				case DirectionEnum.North_North_East:
					return "North North-East";
				case DirectionEnum.North_North_West:
					return "North North-West";
				case DirectionEnum.North_West:
					return "North West";
				case DirectionEnum.South:
					return "South";
				case DirectionEnum.South_East:
					return "South East";
				case DirectionEnum.South_South_East:
					return "South South-East";
				case DirectionEnum.South_South_West:
					return "South South-West";
				case DirectionEnum.South_West:
					return "South West";
				case DirectionEnum.West:
					return "West";
				case DirectionEnum.West_North_West:
					return "West North-West";
				case DirectionEnum.West_South_West:
					return "West South-West";
				case DirectionEnum.Unknown:
					return "Unknown";
				default:
					return "Unknown";
			}
		}

		/// <summary>
		/// fB = fallsBetween.
		/// </summary>
		///
		/// <param name="val"> The value. </param>
		/// <param name="min"> The minimum. </param>
		/// <param name="max"> The maximum. </param>
		///
		/// <returns>
		/// True if it succeeds, false if it fails.
		/// </returns>
		private static bool fB(double val, double min, double max)
		{
			if ((min <= val) && (val <= max))
				return true;
			return false;
		}

		/// <summary>
		/// Assign direction.
		/// </summary>
		///
		/// <param name="degree"> The degree. </param>
		///
		/// <returns>
		/// A DirectionEnum.
		/// </returns>
		private DirectionEnum assignDirection(double degree)
		{
			if (fB(degree, 348.75, 360))
				return DirectionEnum.North;
			if (fB(degree, 0, 11.25))
				return DirectionEnum.North;
			if (fB(degree, 11.25, 33.75))
				return DirectionEnum.North_North_East;
			if (fB(degree, 33.75, 56.25))
				return DirectionEnum.North_East;
			if (fB(degree, 56.25, 78.75))
				return DirectionEnum.East_North_East;
			if (fB(degree, 78.75, 101.25))
				return DirectionEnum.East;
			if (fB(degree, 101.25, 123.75))
				return DirectionEnum.East_South_East;
			if (fB(degree, 123.75, 146.25))
				return DirectionEnum.South_East;
			if (fB(degree, 168.75, 191.25))
				return DirectionEnum.South;
			if (fB(degree, 191.25, 213.75))
				return DirectionEnum.South_South_West;
			if (fB(degree, 213.75, 236.25))
				return DirectionEnum.South_West;
			if (fB(degree, 236.25, 258.75))
				return DirectionEnum.West_South_West;
			if (fB(degree, 258.75, 281.25))
				return DirectionEnum.West;
			if (fB(degree, 281.25, 303.75))
				return DirectionEnum.West_North_West;
			if (fB(degree, 303.75, 326.25))
				return DirectionEnum.North_West;
			if (fB(degree, 326.25, 348.75))
				return DirectionEnum.North_North_West;
			return DirectionEnum.Unknown;
		}

		#endregion Methods
	}
}
