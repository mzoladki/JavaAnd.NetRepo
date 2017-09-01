using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTTT
{
    public class DemotTask: Task
    {
        public string tag { set; get; }
        public string url { set; get; }

        public DemotTask()
        {
            this.name = "";
            this.email = "";
            this.tag = "";
            this.url = "";
            this.action = "";
        }
        public DemotTask(string name, string email, string tag, string url, string action)
        {
            this.name = name;
            this.tag = tag;
            this.url = url;
            this.email = email;
            this.action = action;
        }

        public override void SendEmail()
        {
            Console.WriteLine(this);
            try
            {
                HtmlSender htmlsender = new HtmlSender();
                var imageUrl = htmlsender.searchSiteForImage(tag, url);
                string file_name = tag + ".jpg";
                htmlsender.downloadImage(imageUrl, file_name);

                htmlsender.sendEmail(email, file_name,"Image sent");
                File.Delete(file_name);
                Log.createJTTTLogFile(tag, url, email);
                MessageBox.Show("Wykonano zadanie: " + name);
            }
            catch (Exception log)
            {
                MessageBox.Show("Nie udalo sie wykonac zadania: " + name);
                Log.createErrorFile(log.Message);
            }
        }
        public override void Show()
        {
            Console.WriteLine(this);
            try
            {
                HtmlSender htmlsender = new HtmlSender();
                var imageUrl = htmlsender.searchSiteForImage(tag, url);
                string file_name = tag + ".jpg";
                htmlsender.downloadImage(imageUrl, file_name);
                Form form3 = new Form3(tag, file_name);
                form3.Show();
                Log.createJTTTLogFile(tag, url, email);
            }
            catch (Exception log)
            {
                MessageBox.Show("Nie udalo sie wykonac zadania: " + name);
                Log.createErrorFile(log.Message);
            }
        }
        public override string ToString()
        {
            return "name: " + this.name + " tag: " + this.tag + " url: " + this.url + " email: " + this.email + " action: " + this.action;
        }

    }
}
