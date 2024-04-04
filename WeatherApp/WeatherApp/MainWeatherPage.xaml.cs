using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainWeatherPage : ContentPage
    {
        string city;
        public MainWeatherPage(string city)
        {
            InitializeComponent();
            this.city = city;
            ShowInfo();
        }
        public MainWeatherPage()
        {
            InitializeComponent();
            city = "Москва";
            ShowInfo();
        }
        void ShowInfo()
        {
            string json = SiteFromUrl.GetString("https://api.weatherapi.com/v1/current.json?key=cba90a03fb4146d0861100301231806&q=" + city); 
            Root weather = WeatherFromJson.GetWeather(json);
            cityLabel.Text = city;
            weatherLabel.Text = weather.current.condition.text;
            tempLabel.Text = weather.current.temp_c.ToString()+ "°C";
            windSpeedLabel.Text = "Скорость ветра: " + Math.Round (weather.current.wind_kph* 0.27777777778,2) + " м/с";
            humindityLabel.Text ="Влажность воздуха: "+weather.current.humidity+"%";
            weatherPicture.Source = ImageSource.FromUri( new Uri(
               "https:"+ weather.current.condition.icon));
            DateTime Time = DateTime.Parse(weather.location.localtime);
            localTime.Text = Time.ToString("hh:mm");
            if (weather.current.is_day ==0)
                background.BackgroundImageSource = "nightImage.jpg";
            else
                background.BackgroundImageSource = "sunImage.jpg";

        }
    }
}