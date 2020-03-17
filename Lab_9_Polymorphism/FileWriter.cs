using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_9_Polymorphism
{
    class FileWriter
    {
        private const string userLogFile = "D:\\weblog\\userlog.txt";


        public void ExampleWriteFile()
        {
            string fileName = "D:\\weblog\\log1.txt";
            string data = "Print this info to a log. \n";
            File.AppendAllText(fileName, data);

        }

        public void UpdateUserLog(string userName, DateTime logonTime, bool wasLoginSuccessful)
        {
            if (wasLoginSuccessful == true)
            {
                string logEntry = userName + " successfully logged in at " + logonTime + "\n";
                File.AppendAllText(userLogFile, logEntry);
            }
            else
            {
                string logEntry = userName + " entered a bad password at " + logonTime + "\n";
                File.AppendAllText(userLogFile, logEntry);

            }
        }

        public void CreateHTML(StringBuilder htmlText)
        {
            File.WriteAllText("D:\\weblog\\myHTML.html", htmlText.ToString());
        }
    }
}
