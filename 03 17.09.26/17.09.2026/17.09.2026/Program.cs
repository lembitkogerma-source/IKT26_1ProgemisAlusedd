namespace _17._09._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("teha üks if and else nestimine iseseisvalt");
            Console.WriteLine("teise else if-i sisse panna if and else nestimine");
            //konsool küsib numbrit
            //if võrdub 12
            //else if ja siia sisse omakorda teha if ning else. Else if tingimus on, et
            //muutuja on suurem kui 20
            //else ja seal väljastab konsool teksti: mingid kahtlased väärtused

            string number = Console.ReadLine();
            int numberInt = int.Parse(number);

            if (numberInt == 12)
            {
                Console.WriteLine("number on 12");
            }
            else if (numberInt > 20)
            {
                if (numberInt > 30)
                {
                    Console.WriteLine("sinu vanus on 31 või vanem");
                }
                else
                {
                    Console.WriteLine("sinu vanus on 21 kuni 30");
                }                   
            }
            else
            {
                Console.WriteLine("kahtlane väärtus");
            }
        }     
    }
}
