using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ToMainWeatherPage()
        {
            await Navigation.PushModalAsync(new MainWeatherPage(cityEntry.Text));
        }
        private void findCityBtn_Clicked(object sender, EventArgs e)
        {
            ToMainWeatherPage();
        }
    }
}
