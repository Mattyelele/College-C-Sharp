using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }


        private static bool MainMenu()
        {
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("1) Variables");
            Console.WriteLine("2) Conversion");
            Console.WriteLine("3) Methods");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    variablesTask();
                    return true;
                case "2":
                    conversision();
                    return true;
                case "3":
                    Methods();
                    return true;
                case "4":
                    exit();
                    return true;
                default:
                    return true;
            }
        }

        private static void variablesTask()
        {
            Console.Clear();

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

            Console.WriteLine("\nPress 0 To Go Back To The Main Menu");
            
            switch (Console.ReadLine()) 
            {
                case "0":
                    MainMenu();
                    return;
            }
            
            Console.ReadKey();
        }

        private static void conversision()
        {
            Console.Clear();
            Console.Title = "Conversion";
            Console.WriteLine("Please Enter a Number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now Enter Another Number: ");
            double sum = num + Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total = " + sum);

            Console.WriteLine("\nPress 0 To Go Back To The Main Menu");

            switch (Console.ReadLine())
            {
                case "0":
                    MainMenu();
                    return;
            }
        }

        private static void Methods()
        {
            Console.Clear();
            static void greet()
            {
                Console.WriteLine("Hello There");
            }

            static int apples()
            {
                Console.WriteLine("Enter Number Of Apples");
                int numberApples = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Number of Apples is... " + numberApples);
                return numberApples;
            }

            static int oranges()
            {
                int numberOranges;
                Console.WriteLine("Enter Number Of Oranges");
                numberOranges = Convert.ToInt16(Console.ReadLine());
                return numberOranges;
            }

            static int pears()
            {
                int numberPears;
                Console.WriteLine("Enter Number Of Pears");
                numberPears = Convert.ToInt16(Console.ReadLine());
                return numberPears;
            }

            int numberApples1, numberOranges1, numberPears1, totalFruit;
            double weightApple = 30.5;
            double weightOranges = 41.5;
            double weightPear = 35.6;
            double weightTotal;
            greet();
            numberApples1 = apples();
            numberOranges1 = oranges();
            numberPears1 = pears();
            totalFruit = (numberApples1 + numberOranges1 + numberPears1);
            weightTotal = (numberApples1 + weightApple) + (numberOranges1 + weightOranges) + (numberPears1 + weightPear);
            Console.WriteLine("The total number of fruit is... " + totalFruit + " items.");
            Console.WriteLine("The total weight of the fruit is... " + weightTotal + " grams");
            
            Console.WriteLine("\nPress 0 To Go Back To The Main Menu");

            switch (Console.ReadLine())
            {
                case "0":
                    MainMenu();
                    return;
            }
        }

        private static void exit()
        {
            Environment.Exit(0);
        }

    }

}
