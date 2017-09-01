using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTTT
{
    public partial class Form2 : Form
    {
        public Form2(string cityName, string temp, string windSpeed, string image)
        {
            InitializeComponent();
            CityName.Text = cityName;
            MessageBoxWindow.Text = $"temperatura: {temp} wiatr wieje z predkoscia: {windSpeed}";
            pictureBox.ImageLocation = image;
            //WebClient wc = new WebClient();
            //var json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" + miasto + "&appid=745b7c52e9ca8eb03615582474299723");
            //var x = JsonConvert.DeserializeObject<WeatherObject>(json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void CityName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
