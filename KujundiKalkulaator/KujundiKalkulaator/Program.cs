namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            // Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3;

           
            int side = roundRadius * 2;

            // Ruudu pindala = külg * külg
            int area = side * side;

            // Ruudu ümbermõõt = 4 * külg
            int perimeter = 4 * side;

            
            Console.WriteLine($"Ruudu külje pikkus: {side}");
            Console.WriteLine($"Ruudu pindala: {area}");
            Console.WriteLine($"Ruudu ümbermõõt: {perimeter}");
        }
    }
}