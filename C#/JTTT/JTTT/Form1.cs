using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using System.Net.Mail;
using System.Net;


namespace JTTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            var list = listBox.Items;
            HtmlSender htmlsender = new HtmlSender();
            foreach (Task task in list)
            {
                if (task.action == "show") task.Show(); 
                else task.SendEmail();
            }
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            using (var db = new Database())
            {
                if(tabControl2.SelectedTab.Text.Equals(mailPage.Text) && TaskName.Text.Length != 0 && UrlTextBox.Text.Length != 0 && TagTextBox.Text.Length != 0 && EmailTextBox.Text.Length!=0)
                {
                    db.Task.Add(new DemotTask(TaskName.Text, EmailTextBox.Text, TagTextBox.Text, UrlTextBox.Text, "email"));
                    db.SaveChanges();
                }
                else if (tabControl2.SelectedTab.Text.Equals(comPage.Text) && TaskName2.Text.Length != 0 && UrlTextBox.Text.Length != 0 && TagTextBox.Text.Length != 0)
                {
                    db.Task.Add(new DemotTask(TaskName.Text, EmailTextBox.Text, TagTextBox.Text, UrlTextBox.Text, "show"));
                    db.SaveChanges();
                }
                else if(tabControl2.SelectedTab.Text.Equals(mailPage.Text) && Temperature.Text.Length!=0 && CityName.Text.Length!= 0 && TaskName.Text.Length != 0 && EmailTextBox.Text.Length != 0)
                {
                    db.Task.Add(new WeatherTask(TaskName2.Text, EmailTextBox.Text, CityName.Text, Convert.ToDouble(Temperature.Text), "email"));
                    db.SaveChanges();
                }
                else if (tabControl2.SelectedTab.Text.Equals(comPage.Text) && Temperature.Text.Length != 0 && CityName.Text.Length != 0 && TaskName2.Text.Length != 0)
                {
                    db.Task.Add(new WeatherTask(TaskName2.Text, EmailTextBox.Text, CityName.Text, Convert.ToDouble(Temperature.Text), "show"));
                    db.SaveChanges();
                }

                listBox.Items.Clear();

                foreach(var t in db.Task)
                {
                    listBox.Items.Add(t);
                }
            }
            CityName.Text = "";
            Temperature.Text = "";
            TaskName.Text = "";
            TaskName2.Text = "";
            TagTextBox.Text = "";
            EmailTextBox.Text = "";
            UrlTextBox.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            using (var db = new Database())
            {
                foreach(var t in db.Task)
                {
                    db.Task.Remove(t);
                }
                db.SaveChanges();
            }
        }

        private void DeSerializeButton_Click(object sender, EventArgs e)
        {
            BindingList < Task > listOfTasks = Task.ReadFromFile("file.xml");
            foreach (Task task in listOfTasks)
            {
                listBox.Items.Add(task);
            }
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            Task.AddToFile("file.xml", listBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new Database())
            {
                foreach (var t in db.Task)
                {
                    listBox.Items.Add(t);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TaskName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Demot_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
