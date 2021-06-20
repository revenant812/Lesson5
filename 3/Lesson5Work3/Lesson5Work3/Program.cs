using System;
using System.IO;


namespace Lesson5Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввести с клавиатуры через пробел произвольный набор чисел (0...255): ");
            string text = Console.ReadLine();
            string[] array = text.Split(" ");
            for (int i = 0; i < array.Length; i++)
            {               
                int a = Convert.ToInt32(array[i]);                
                if ((a > 255) || (a < 0))
                {
                    Console.WriteLine("введено число больше 255");
                    return;
                }                                                                                                
            }
            byte[] bytearray = new byte[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                bytearray[i] = Convert.ToByte(array[i]);
            }
            File.WriteAllBytes("C:/Users/Дима/Desktop/bytes.bin", bytearray);
            Console.Write("Проверка: ");
            byte[] fromFile = File.ReadAllBytes("C:/Users/Дима/Desktop/bytes.bin");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{fromFile[i]} ");
            }
            Console.WriteLine();
        }
    }
}
