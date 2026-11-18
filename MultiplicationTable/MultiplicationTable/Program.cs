namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");

            int j, i, n;

            Console.WriteLine("Sisesta tabelisse number, mis on viimane korrutis");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }

                Console.WriteLine();
            }
        }
    }
}