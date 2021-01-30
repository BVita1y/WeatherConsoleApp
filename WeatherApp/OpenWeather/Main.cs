using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherApp
{
    class Main
    {

        const double TRANSITION = 273.15;

        private double temp;
        private double feels_like;
        private double pressure;
        private double temp_min;
        private double temp_max;

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        public double Temp {
            get
            {
                return temp;
            }
            set
            {
                temp = value - TRANSITION;
            }
        }
        public double FeelsLike {
            get {
                return feels_like;
            }
            set
            {
                feels_like = value - TRANSITION;
            }
        }
        public double Pressure
        {
            get
            {
                return pressure;
            }
            set
            {
                pressure = value / 1.3332239;
            }
        }
        public double TempMin
        {
            get
            {
                return temp_min;
            }
            set
            {
                temp_min = value - TRANSITION;
            }
        }
        public double TempMax
        {
            get
            {
                return temp_max;
            }
            set
            {
                temp_max = value - TRANSITION;
            }
        }
    }
}
