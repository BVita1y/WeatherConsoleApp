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
        public string _base;

        [JsonProperty("main")]
        public Main main;

        [JsonProperty("visibility")]
        public double visibility;

        [JsonProperty("wind")]
        public Wind wind;

        [JsonProperty("clouds")]
        public Clouds clouds;

        [JsonProperty("dt")]
        public double dt;

        [JsonProperty("sys")]
        public Sys sys;

        public double timezone;

        [JsonProperty("id")]
        public int id;

        [JsonProperty("name")]
        public string name;

        [JsonProperty("code")]
        public int code;
    }
}
