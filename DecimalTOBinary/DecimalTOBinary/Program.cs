namespace DecimalTOBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");

            Console.WriteLine("Sisesta number:");
            int num = Convert.ToInt32(Console.ReadLine());

            //otsida internetist koodi]ik ülesse
            //peab olema while-ga tehtud

            if (num == 0)
            {
                Console.WriteLine("Binaarkood: 0");
                return;
            }

            string binary = "";
            int temp = num;

            
            while (temp > 0)
            {
                int remainder = temp % 2;
                binary = remainder + binary;
                temp = temp / 2;
            }

            Console.WriteLine($"Arv {num} kahendsüsteemis on: {binary}");
        }
    }
}