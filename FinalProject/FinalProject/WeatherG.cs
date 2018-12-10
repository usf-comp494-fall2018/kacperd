using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class WeatherG
    {
        public int id { get; set; }
        public int period { get; set; }
        public string icon { get; set; }
        public string title { get; set; }
        public string fcttext { get; set; }
        public string lastcheck { get; set; }

        public string data
        {
            get
            {
                return title + ": " + fcttext;
            }
        }

        public string imgsource
        {
            get
            {
                string temp;
                switch (icon.ToUpper())
                {
                    case "CLEAR":
                        temp = "Sunny";
                        break;
                    case "NT_CLEAR":
                        temp = "Moon";
                        break;
                    case "OVERCAST":
                    case "CLOUDY":
                    case "MOSTLYCLOUDY":
                    case "NT_MOSTLYCLOUDY":
                        temp = "Overcast";
                        break;
                    case "PARTLYCLOUDY":
                        temp = "PartlyCloudy";
                        break;
                    case "NT_PARTLYCLOUDY":
                        temp = "NightPartlyCloudy";
                        break;
                    case "RAIN":
                    case "NT_RAIN":
                        temp = "Rain";
                        break;
                    case "SNOW":
                    case "NT_SNOW":
                        temp = "Snow";
                        break;
                    case "STORM":
                        temp = "Thunderstorm";
                        break;
                    case "WINDY":
                        temp = "Windy";
                        break;
                    case "FOG":
                        temp = "Fog";
                        break;
                    default:
                        temp = "Default";
                        break;
                }
                return "ms-appx:///Assets/" + temp + ".png";
            }
        }

    }
}
