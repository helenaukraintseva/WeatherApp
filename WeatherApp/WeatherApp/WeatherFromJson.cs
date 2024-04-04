using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    internal class WeatherFromJson
    {
        public static Root GetWeather(string json)
        {
            return  JsonConvert.DeserializeObject<Root>(json);
        }
    }
}
