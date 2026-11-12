using System;

namespace ForLoopPyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta püramiidi ridade arv: ");

          
           if (int.TryParse(Console.ReadLine(), out int ridadeArv) && ridadeArv > 0)
            {
                Console.WriteLine(); 

                for (int i = 1; i <= ridadeArv; i++)
                {
                    
                    for (int j = 1; j <= ridadeArv - i; j++)
                    {
                        Console.Write(" ");
                    }

                   
                    for (int k = 1; k <= (2 * i - 1); k++)
                    {
                        Console.Write("*");
                    }

                    
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Palun sisesta korrektne positiivne täisarv!");
            }
        }
    }
}

