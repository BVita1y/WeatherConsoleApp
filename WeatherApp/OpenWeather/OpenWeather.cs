using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherApp
{
    class OpenWeather
    {
        [JsonProperty("coord")]
        public Coord coord;

        [JsonProperty("weather")]
        public Weather[] weather;

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main main;

        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind wind;

        [JsonProperty("clouds")]
        public Clouds clouds;

        [JsonProperty("dt")]
        public double Dt { get; set; }

        [JsonProperty("sys")]
        public Sys sys;

        [JsonProperty("timezone")]
        public double Timezone { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
