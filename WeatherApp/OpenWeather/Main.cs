using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    class Main
    {
        private double temp;
        private double feels_like;
        private double pressure;
        private double temp_min;
        private double temp_max;
        public double humidity;

        public double Temp {
            get
            {
                return temp;
            }
            set
            {
                temp = value - 273.15;
            }
        }
        public double FeelsLike {
            get {
                return feels_like;
            }
            set
            {
                feels_like = value - 273.15;
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
                temp_min = value - 273.15;
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
                temp_max = value - 273.15;
            }
        }
    }
}
