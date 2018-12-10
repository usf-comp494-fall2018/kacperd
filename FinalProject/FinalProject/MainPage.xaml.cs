using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FinalProject
{
    public sealed partial class MainPage : Page
    {
        //will execute when app is opened
        public MainPage()
        {
            this.InitializeComponent();
            CallAPI();
        }

        private async void CallAPI()
        {
            //client gathers raw JSON data from URL
            var client = new HttpClient();
            
            //string is converted to WeatherD object
            string json_data = await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/3");
            WeatherD one_day = JsonConvert.DeserializeObject<WeatherD>(json_data);

            //string is converted to list of WeatherG objects
            json_data = await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather");
            List<WeatherG> three_day = JsonConvert.DeserializeObject<List<WeatherG>>(json_data);

            //binding
            OneDayTextBlock.DataContext = one_day;
            ThreeDayList.ItemsSource = three_day;
        }
    }
}