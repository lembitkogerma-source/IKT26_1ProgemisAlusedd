using System;

namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //meil on münt, mille diameeter on 25.75 mm
            //arvutada välja Maa ümbermõõt
            //mitu münti mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündidiameetrit ja Maa raadiust

            double coinDiameter = 25.75; // mm
            double earthRadius = 6378000000;

            // 1. Maa ümbermõõdu arvutamine (Valem: C = 2 * pi * r)
            double earthCircumference = 2 * Math.PI * earthRadius;

            // 2. Mitu münti mahub järjestikku ümber Maa (Ümbermõõt jagatud mündi diameetriga)
            double coinsCount = earthCircumference / coinDiameter;

            // Tulemuste kuvamine
            Console.WriteLine($"Maa ümbermõõt: {earthCircumference:N0} mm");
            Console.WriteLine($"Müntide arv ümber Maa: {coinsCount:N0}");
        }
    }
}
