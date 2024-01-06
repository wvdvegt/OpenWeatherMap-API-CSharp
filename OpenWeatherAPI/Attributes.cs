namespace OpenWeatherAPI
{
    using System;

    /// <summary>
    /// Attribute for units.
    /// </summary>
    internal class UnitsAttribute : Attribute
    {
        #region Fields

        /// <summary>
        /// The name.
        /// </summary>
        protected string Name;

        /// <summary>
        /// The units.
        /// </summary>
        protected string Units;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <param name="name">  The name. </param>
        /// <param name="units"> The units. </param>
        public UnitsAttribute(string name, string units)
        {
            //TODO Note that the units vary by query (default, metric and imperial)

            Name = name;
            Units = units;
        }

        #endregion Constructors
    }
}
