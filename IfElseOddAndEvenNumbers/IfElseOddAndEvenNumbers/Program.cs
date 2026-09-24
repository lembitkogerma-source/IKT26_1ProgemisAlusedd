namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Konsool küsib numbrit
            Console.Write("Sisesta täisarv: ");
            string input = Console.ReadLine();

            // Number tuleb ära parsida
            if (int.TryParse(input, out int number))
            {
                // If ja else juures toimub kontroll, kas on paaris või paaritu number
                if (number % 2 == 0)
                {
                    Console.WriteLine($"Number {number} on paaris.");
                }
                else
                {
                    Console.WriteLine($"Number {number} on paaritu.");
                }
            }
            else
            {
                Console.WriteLine("See ei ole korrektne täisarv!");
            }
        }
    }
}


