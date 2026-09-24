namespace IfElseMethodCall
{
    internal class Program
    {
        // Main on meetod, mis läheb alati esimesena tööle[cite: 1]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Kitty");

            // Küsime kasutajalt, kas ta soovid meetodit välja kutsuda
            Console.WriteLine("Kas sa soovid HelloMethod meetodit välja kutsuda? (jah/ei)");
            string vastus = Console.ReadLine();

            // Kasutame if ja else tingimuslauset[cite: 1]
            if (vastus.ToLower() == "jah")
            {
                // Kutsume välja teise meetodi
                HelloMethod();
            }
            else
            {
                Console.WriteLine("Meetodit ei kutsutud välja.");
            }
        }

        // Teha teine meetod siia ja nimeks on selle HelloMethod[cite: 1]
        static void HelloMethod()
        {
            Console.WriteLine("Tere! See on HelloMethod meetod.");
        }
    }
}
