using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using WindowsInput;
using System.Diagnostics;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    public partial class Weather_information : Form
    {
        public Weather_information(string city, string country)
        {
            List<string> weatherdata = new List<string>();
            InitializeComponent();
            weatherdata = Get_Weather_Information(city, country);
            city_name.Text = city;
            temperature.Text = weatherdata[1];
            wind_speed.Text = weatherdata[3];
            country_name.Text = country;
            w_icons.Image = weather_icons.Images[4];
            DateTime today = DateTime.Today;
            string day = today.DayOfWeek.ToString();
            date_time_with_weather.Text = today.ToString("d")+" ,"+day;
            if (city.Equals("Jaipur"))
            {
                this.BackgroundImage = background.Images[0];
            }
            else if (city.Equals("Tokyo"))
            {
                this.BackgroundImage = background.Images[1];
            }
            else if (city.Equals("London"))
            {
                this.BackgroundImage = background.Images[2];
            }

            if (weatherdata[6].Equals("haze"))
            {
                w_icons.Image = weather_icons.Images[7];
            }
            else if (weatherdata[6].Equals("broken clouds"))
            {
                w_icons.Image = weather_icons.Images[5];
            }
            else if (weatherdata[6].Equals("few clouds"))
            {
                w_icons.Image = weather_icons.Images[4];
            }
            else if (weatherdata[6].Equals("clear sky") || weatherdata[6].Equals("sky is clear"))
            {
                w_icons.Image = weather_icons.Images[3];
            }
            else if (weatherdata[6].Equals("overcast clouds"))
            {
                w_icons.Image = weather_icons.Images[5];
            }
            else if (weatherdata[6].Equals("scattered clouds"))
            {
                w_icons.Image = weather_icons.Images[8];
            }
            else if (weatherdata[6].Equals("light rain"))
            {
                w_icons.Image = weather_icons.Images[9];
            }
            else if (weatherdata[6].Equals("smoke"))
            {
                w_icons.Image = weather_icons.Images[7];
            }
        }

        public static List<string> Get_Weather_Information(string destination_city_name, string destination_country_name)
        {
            using (WebClient web = new WebClient())
            {
                List<string> data = new List<string>();
                string cloud_description;
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q="+ destination_city_name + ","+destination_country_name+ "&appid=5ee46b3aec3a387fea8082c99d0355cd");
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<Weather_Info.root>(json);
                Weather_Info.root output = result;
                string CityName = string.Format("{0}", output.name);
                string CountryName = string.Format("{0}", output.sys.country);
                double t = output.main.temp_max;
                t = t - 273.15;
                int tt = (int)t;
                string MaxTemperature = string.Format("{0} \u00B0" + "C", tt);
                string WindSpeed = string.Format("{0}", output.wind.speed);
                string Humidity = string.Format("{0}", output.main.humidity);
                int clouds_percentage = output.clouds.all;
                cloud_description = output.weather[0].description;
                data.Add(CityName);//1
                data.Add(MaxTemperature);//2
                data.Add(Humidity);//3
                data.Add(WindSpeed);//4
                data.Add(CountryName);//5
                data.Add(clouds_percentage.ToString());//6
                data.Add(cloud_description);//7
                return data;
            }
        }

        private void Weather_information_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            show.Start();
        }

        public static void Show_Weather_notification(string city, string country)
        {
            new Yuuto_VPA_Virtual_Private_Assistant_.Weather_information(city,country).Show();
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            close_weather_notify.Start();
        }
        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                show.Stop();
            }
        }

        private void close_weather_notify_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.2;
            }
            else
            {
                this.Close();
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

            Process.Start("microsoft-weather://");
        }
    }
}
