// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CodeBeautify;
//
//    var welcome4 = Welcome4.FromJson(jsonString);

namespace OpenWeatherAPI
{
    using System;

    using System.Text.Json;
	using System.Text.Json.Serialization;

    public partial class FullWeatherData

    {
		[JsonPropertyName("coord")]
        public Coord_ Coord { get; set; }

        [JsonPropertyName("weather")]
        public Weather_[] Weather { get; set; }

        [JsonPropertyName("base")]
        public string Base { get; set; }

        [JsonPropertyName("main")]
        public Main_ Main { get; set; }

        [JsonPropertyName("visibility")]
        public long Visibility { get; set; }

        [JsonPropertyName("wind")]
        public Wind_ Wind { get; set; }

        [JsonPropertyName("rain")]
        public Rain_ Rain { get; set; }

        [JsonPropertyName("clouds")]
        public Clouds_ Clouds { get; set; }

        [JsonPropertyName("dt")]
        public long Dt { get; set; }

        [JsonPropertyName("sys")]
        public Sys_ Sys { get; set; }

        [JsonPropertyName("timezone")]
        public long Timezone { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("cod")]
        public long Cod { get; set; }
    }

    public partial class Clouds_
    {
        [JsonPropertyName("all")]
        public long All { get; set; }
    }

    public partial class Coord_
    {
        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }
    }

    public partial class Main_
    {
        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonPropertyName("temp_min")]
        public double TempMin { get; set; }

        [JsonPropertyName("temp_max")]
        public double TempMax { get; set; }

        [JsonPropertyName("pressure")]
        public long Pressure { get; set; }

        [JsonPropertyName("humidity")]
        public long Humidity { get; set; }
    }

    public partial class Rain_
    {
        [JsonPropertyName("1h")]
        public double The1H { get; set; }
    }

    public partial class Sys_
    {
        [JsonPropertyName("type")]
        public long Type { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("sunrise")]
        public long Sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public long Sunset { get; set; }
    }

    public partial class Weather_
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

    public partial class Wind_
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("deg")]
        public long Deg { get; set; }
    }

    //public partial class Welcome4
    //{
    //    public static Welcome4 FromJson(string json) => JsonConvert.DeserializeObject<Welcome4>(json, CodeBeautify.Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this Welcome4 self) => JsonConvert.SerializeObject(self, CodeBeautify.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}
}
