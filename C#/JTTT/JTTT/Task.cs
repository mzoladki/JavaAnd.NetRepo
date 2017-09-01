using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace JTTT
{
    public class Task
    {
        public int Id { set; get; }
        public string name { set; get; }
        public string email { set; get; }
        public string action { get; set; }
        public Task()
        {
            this.name = "";
        }
        
        public virtual void SendEmail()
        {
            
        }
        public virtual void Show()
        { 
}
        public static BindingList<Task> BindFromListBox(ListBox listBox)
        {
            BindingList<Task> taskList = new BindingList<Task>();

            var list = listBox.Items;
            foreach (Task task in list)
            {
                taskList.Add(task);
            }
            return taskList;
        }

        public static void AddToFile(string nameOfFile, ListBox listBox)
        {
            var taskList = BindFromListBox(listBox);

            using (var stream = new FileStream(nameOfFile, FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(BindingList<Task>));

                XML.Serialize(stream, taskList);

            }

        }

        static public BindingList<Task> ReadFromFile(string nameOfFile)
        {
            BindingList<Task> ListOfTasks = new BindingList<Task>();

            using (var stream = new FileStream(nameOfFile, FileMode.Open))
            {
                XmlSerializer XML = new XmlSerializer(typeof(BindingList<Task>));
                return (BindingList<Task>)XML.Deserialize(stream);  
            }

        }

    }
}
