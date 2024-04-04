using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace WeatherApp
{
    internal class SiteFromUrl
    {
        static public string GetString(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            return sr.ReadToEnd();
        }
    }
}
