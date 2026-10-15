namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number!");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine number!");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Kasuta tingmärki: *, /, +, -");
            //nüüd tuleb teha switchi valik, kas *, /, +, -
            //tuleb teha neli case, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati Parsimisel



            char operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Tulemus: {num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Tulemus: {num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Tulemus: {num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Tulemus: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Nulliga jagamine ei ole lubatud!");
                    }
                    break;
                default:
                    Console.WriteLine("Tundmatu tingmärk!");
                    break;
            }
        }
    }
}
      
