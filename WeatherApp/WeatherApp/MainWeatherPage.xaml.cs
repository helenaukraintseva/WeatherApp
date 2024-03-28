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
        }
        public MainWeatherPage()
        {
            InitializeComponent();
            city = "Москва";
        }
    }
}