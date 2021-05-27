using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'A';
            int number = 100;
            float bodyTemp = 98.6f;
            double pi = 3.14159;
            decimal largeNumber = 1000.00m;
            bool flag = false;
            string text = "I love C#";

            Console.WriteLine("Char letter: \t" + letter);
            Console.WriteLine("int number: \t" + number);
            Console.WriteLine("float body temp: \t" + bodyTemp);
            Console.WriteLine("double pi: \t" + pi);
            Console.WriteLine("decimal sum: \t" + largeNumber);
            Console.WriteLine("bool flag \t" + flag);
            Console.WriteLine("string text: \t" + text);
            Console.ReadKey();
        }
    }
}
