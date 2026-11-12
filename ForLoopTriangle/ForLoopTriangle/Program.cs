namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk e poolik püramiid");
            Console.WriteLine("------------------------------------");
            // \n tähendab uut rida
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv:");
            //for tuleb panna for loopi sisse

            
            int ridadeArv = int.Parse(Console.ReadLine());

            Console.WriteLine(); 

            
            for (int i = 1; i <= ridadeArv; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                
                Console.WriteLine();
            }
        }
    }
}