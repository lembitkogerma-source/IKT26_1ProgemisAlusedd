namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //tuleb teha switch, kus esimene case on 10, teine on 20 ja kolmas on 30


            int input = int.Parse(Console.ReadLine());

            switch (input) 

            {
                case 10:
                    Console.WriteLine("Arv on 10");
                    break;
                case 20:
                    Console.WriteLine("Arv on 20");
                    break;
                case 30:
                    Console.WriteLine("Arv on 30");
                    break;
                default:
                    Console.WriteLine("Arv ei ole 10, 20 ega 30");
                    break;
            }
        }
    }
}


