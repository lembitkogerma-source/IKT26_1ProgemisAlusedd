using System;

namespace SwitchLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meetodi valimine");
            Console.WriteLine("1 - auh");
            Console.WriteLine("2 - tahan magada");
            Console.WriteLine("3 - tahan õppida");
            Console.Write("Tee oma valik (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FirstMethod();
                    break;
                case "2":
                    SecondMethod();
                    break;
                case "3":
                    ThirdMethod();
                    break;
                default:
                    Console.WriteLine("Vigane valik! Palun vali number 1, 2 või 3.");
                    break;
            }
        }

        // Esimene meetod
        static void FirstMethod()
        {
            Console.WriteLine("auh");
        }

        // Teine meetod
        static void SecondMethod()
        {
            Console.WriteLine("tahan magada");
        }

        // Kolmas meetod
        static void ThirdMethod()
        {
            Console.WriteLine("tahan õppida");
        }
    }
}