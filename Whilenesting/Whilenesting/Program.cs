namespace Whilenesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb kasutada while ja omakorda while while-i sisse panna 
            //while nesting
            //while kordab ennast 5 korda

            int i = 1; 

           
            while (i <= 5)
            {
                Console.WriteLine($"while: {i}");

                int j = 1; 

                
                while (j <= 3)
                {
                    Console.WriteLine($"kordus: {j}");
                    j++;
                }

                i++;
            }
        }
    }
}
