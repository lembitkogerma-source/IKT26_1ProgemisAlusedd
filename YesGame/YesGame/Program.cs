namespace YesGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta sõna");

            string word = Console.ReadLine();

            //while ja nii kaua tsükkel kestab kuni kasutaja sisestab sõna yes

            while (word != "yes")
            {
                Console.WriteLine("Sisesta sõna:");
                word = Console.ReadLine();
            }

            Console.WriteLine("Tubli! Sisestasid õige sõna.");
        }
    }
}
