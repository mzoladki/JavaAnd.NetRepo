using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTTT
{
    public class WeatherTask: Task
    {
        public string cityName { get; set; }
        public double condition { get; set; }
        public WeatherTask()
        {
            this.name = "";
            this.cityName = "";
            this.action = "";
            this.condition = 0;
        }
        public WeatherTask(string name, string email, string cityName, double condition, string action)
        {
            this.name = name;
            this.email = email;
            this.cityName = cityName;
            this.condition = condition;
            this.action = action;
        }

        public override string ToString()
        {
            return "name: " + this.name + " city: " + this.cityName + " condition: " + this.condition + "action: " + this.action;
        }

        public override void Show()
        {
            HtmlSender htmlsender = new HtmlSender();
            WebClient wc = new WebClient();
            var json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&appid=745b7c52e9ca8eb03615582474299723");
            var x = JsonConvert.DeserializeObject<WeatherObject>(json);
            try
            {
                if (x.main.temp < condition)
                {
                    string imageUrl = "http://openweathermap.org/img/w/" + x.weather[0].icon + ".png";
                    htmlsender.downloadImage(imageUrl, "ikona.jpg");
                    Form form2 = new Form2(cityName, Convert.ToString(x.main.temp), Convert.ToString(x.wind.speed), imageUrl);
                    Log.createJTTTLogFile(cityName, Convert.ToString(condition), email);
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Temperatura we " + cityName + " jest wyższa niż: " + condition);
                }
            }
            catch (Exception log)
            {
                MessageBox.Show("Nie udalo sie wykonac zadania: " + name);
                Log.createErrorFile(log.Message);
            }

        }
        public override void SendEmail()
        {

            Console.WriteLine(this);
            try
            {
                HtmlSender htmlsender = new HtmlSender();
                WebClient wc = new WebClient();
                var json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&appid=745b7c52e9ca8eb03615582474299723");
                var x = JsonConvert.DeserializeObject<WeatherObject>(json);

                if (x.main.temp < condition)
                {
                    string imageUrl = "http://openweathermap.org/img/w/" + x.weather[0].icon + ".png";
                    htmlsender.downloadImage(imageUrl, "ikona.jpg");
                    string weather_text = "miasto: " + cityName + " temperatura: " + x.main.temp + " wiatr wieje z predkoscia: " + x.wind.speed;
                    MessageBox.Show(weather_text);
                    htmlsender.sendEmail(email, "ikona.jpg", weather_text);
                    File.Delete("ikona.jpg");
                    MessageBox.Show("Wykonano zadanie: " + name);
                    Log.createJTTTLogFile(cityName, Convert.ToString(condition), email);
                }
                else
                {
                    MessageBox.Show("Temperatura we " + cityName + " jest wyższa niż: " + condition);
                }

            }
            catch (Exception log)
            {
                MessageBox.Show("Nie udalo sie wykonac zadania: " + name);
                Log.createErrorFile(log.Message);
            }
        }
    }
}
