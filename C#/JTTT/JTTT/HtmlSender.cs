using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Mail;
using System.Net;

namespace JTTT
{
    class HtmlSender
    {
        public string searchSiteForImage(string tag, string url)
        {
            HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            System.Net.WebClient webClient = new System.Net.WebClient();
            webClient.Encoding = Encoding.UTF8;

            var html = System.Net.WebUtility.HtmlDecode(webClient.DownloadString(url));
            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.Descendants("img");
            foreach (var node in nodes)
            {
                if (node.Name == "img")
                {
                    if (node.GetAttributeValue("alt", "").Contains(tag))
                    {
                        if (node.GetAttributeValue("src", "").Contains("http:"))
                        {
                            return node.GetAttributeValue("src", "");
                        }
                    }
                }
            }
            return "";
        }
        public void sendEmail(string to, string file_name, string mailBodyText)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);

            mail.From = new MailAddress("testtestowy228@gmail.com");
            mail.To.Add(to);
            mail.Subject = "Your image in an attachment";
            mail.Body = mailBodyText;
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(file_name);
            mail.Attachments.Add(attachment);

            SmtpServer.Credentials = new System.Net.NetworkCredential("testtestowy228@gmail.com", "Test12345");

            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            attachment.Dispose();
        }
        public void downloadImage(string url, string nameOfFile)
        {
            System.Net.WebClient webClient = new System.Net.WebClient();
            webClient.DownloadFile(url, nameOfFile);   
        }

    }
}
