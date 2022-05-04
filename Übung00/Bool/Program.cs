using System;
using System.Globalization;

/*
Überprüfen Sie in einem Programm

    ob der eingegebene Wert für x im Bereich x1...x2 liegt,
    ob der durch x und y definierte Punkt in einem Rechteck mit den Eckpunkten x1, y1 und x2, y2 liegt,
    ob zwei Punkte die gleichen Koordinaten haben,
    ob mindestens eine der Bedingungen x1<=x<=x2 bzw. y1<=y<=y2 zutrifft.
*/ 

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            try
            {
                Console.Write("x: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("y: ");
                y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("Bad input!");
                return;
            }

            //todo: dynmaic input
            var x1 = 0.1;
            var x2 = 2.0;
            var y1 = -1.1;
            var y2 = 2.7;

            //ob der eingegebene Wert für x im Bereich x1...x2 liegt
            // && logisches UND erwartet links und rechts bool
            var xInRange = x2 >= x && x >= x1;
            //in if-Bedingung darf nur boolscher Wert stehen 
            if(xInRange)
            {
                Console.WriteLine($"{x} is located between {x1} and {x2}");
            }
            else
            {
                Console.WriteLine("x is not in the specified range!");
            }

            //ob der durch x und y definierte Punkt in einem Rechteck mit den Eckpunkten x1, y1 und x2, y2 liegt,
            var yInRange = y2 >= y && y >= y1;
            var isInRect = yInRange && xInRange;

            if(isInRect)
            {
                Console.WriteLine($"({x}, {y}) is located in the given rectangle");
            }
            else
            {
                Console.WriteLine($"({x}, {y}) is not located in the given rectangle");
            }

            //ob zwei Punkte die gleichen Koordinaten haben
            //Problem Gleitpunkzahlen werden nicht exakt gespeichert
            //-> x == y liefert nicht immer richtiges Ergebnis
            // "==" dient als Vergleichsoperator
            // "=" dient als Zuweisungsoperator
            var xEqualToY = Math.Abs(x-y) <= 1.0e-15;

            if(xEqualToY)
            {
                Console.WriteLine($"{x} is equal to {y} ");
            }
            else
            {
                Console.WriteLine($"{x} is not  equal to {y} ");
            }

            //ob mindestens eine der Bedingungen x1<=x<=x2 bzw. y1<=y<=y2 zutrifft
            // logisches ODER ||
            var isInLeastOneRange = xInRange || yInRange;
            Console.WriteLine($"{x} in range or {y} in y range: {isInLeastOneRange}");
            
        }
    }
}





