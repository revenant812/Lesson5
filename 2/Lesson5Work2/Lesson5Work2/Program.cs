using System;
using System.IO;

namespace Lesson5Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime time = DateTime.Now;
            string path = "C:/Users/Дима/Desktop/startup.txt";            
            File.AppendAllText(path, DateTime.Now.ToString("HH:mm:ss"));
            File.AppendAllText(path, Environment.NewLine);
        }
    }
}
