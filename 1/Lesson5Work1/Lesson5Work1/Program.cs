using System;
using System.IO;

namespace Lesson5Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Наберите произвольный набор символов: ");
            string text = Console.ReadLine();
            string filename = "C:/Users/Дима/Desktop/text.txt";
            File.WriteAllText(filename, text);
        } 
    }
}
