namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number:");

            
            if (int.TryParse(Console.ReadLine(), out int number))
            {
               
                string tulemus = number switch
                {
                    >= 0 and <= 100 => "Esimene koondtulemus (0 kuni 100)",
                    >= 101 and <= 200 => "Teine koondtulemus (101 kuni 200)",
                    >= 201 and <= 300 => "Kolmas koondtulemus (201 kuni 300)",
                    _ => "Number ei kuulu ühtegi määratud vahemikku."
                };

                Console.WriteLine(tulemus);
            }
            else
            {
                Console.WriteLine("Palun sisesta kehtiv täisarv!");
            }
        }
    }
}