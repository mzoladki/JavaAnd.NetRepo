using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JTTT
{
    class Log
    {
        public static void createJTTTLogFile(string tag, string url, string email)
        {
            StreamWriter file = new StreamWriter("jttt.log", true);
            file.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                 DateTime.Now.ToLongDateString());
            file.WriteLine("Image from URL: {0}", url);
            file.WriteLine("Tag: {0}", tag);
            file.WriteLine("To email: {0}", email);
            file.Close();
        }

        public static void createErrorFile(string errorMessage)
        {
            StreamWriter file = new StreamWriter("error.log", true);
            file.WriteLine("{0} {1}:    ", DateTime.Now.ToLongTimeString(),
                 DateTime.Now.ToLongDateString());
            file.Write(errorMessage);
            file.Close();
        }
    }
}
