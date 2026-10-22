using System;

class Program
{
    static void Main()
    {
        //1.otsida internetist While koodiga kolmnurga kujundieid ehk tegemise viise
        //2.kui kood on leitud, siis kirjuta see siia
        //3.teha vooskeem
        int ridadeArv = 5;
        int i = 1;

        // Välimine tsükkel ridade jaoks
        while (i <= ridadeArv)
        {
            int j = 1;
            // Sisemine tsükkel tärnide jaoks igal real
            while (j <= i)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine(); // Viib kursori uuele reale
            i++;
        }
    }
}

