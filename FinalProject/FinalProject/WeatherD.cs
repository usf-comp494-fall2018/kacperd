using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class WeatherD
    {
        public int id { get; set; }
        public string observationTime { get; set; }
        public string weather { get; set; }
        public double tempF { get; set; }
        public string relativeHumidity { get; set; }
        public string windDir { get; set; }
        public double windMph { get; set; }
        public string lastcheck { get; set; }

        public string data
        {
            get
            {
                return weather + " with a temp of " + tempF + " degrees F, a humidity of " + relativeHumidity +
                    " and winds in the " + windDir + " direction at " + windMph + " mph. " + observationTime +
                    " and last checked on " + lastcheck;
            }
        }
    }
}
