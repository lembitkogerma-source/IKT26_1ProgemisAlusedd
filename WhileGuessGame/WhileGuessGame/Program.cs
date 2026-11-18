namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //numbri arvamise mäng

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            //tuleb kasuatada while, kus öeldakse, kas sinu
            //pakutud number oli suurem või väiksem

            while (guess != secretNumber)
            {
                Console.Write("Paku number (1-100): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Salajane number on suurem!");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Salajane number on väiksem!");
                    }
                    else
                    {
                        Console.WriteLine($"Õige! Arvasid numbri ära {attempts} katsega.");
                    }
                }
                else
                {
                    Console.WriteLine("Palun sisesta täisarv!");
                }
            }
        }
    }
}