using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vali case 1, 2 või 3:");
        string valik = Console.ReadLine();

        switch (valik)
        {
            case "1":
                Console.WriteLine("Sisesta esimene number:");
                float nr1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta teine number:");
                float nr2 = float.Parse(Console.ReadLine());
                Console.WriteLine($"Tulemus: {nr1} + {nr2} = {nr1 + nr2}");
                break;
            case "2":
                KuvaAuh();
                break;
            case "3":
                Console.WriteLine("Sisesta oma nimi:");
                string nimi = Console.ReadLine();
                Console.WriteLine($"Tere, {nimi}!");
                break;
            default:
                Console.WriteLine("Tundmatu valik!");
                break;
        }
    }

    static void KuvaAuh()
    {
        Console.WriteLine("Auh");
    }
}
