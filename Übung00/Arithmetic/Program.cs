﻿using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3, r = 4;
            double y = 4.0;

            //1.
            // Konvertierung von int zu double nötig damit Division im floatingpoint-Raum
            double d = (double)a/b;
            Console.WriteLine($"d = {d}" );

            //2.
            double f = (a* b) / (c-y) - ((double)a/b);
            Console.WriteLine($"f = {f}");

            //3.
            f = (-b * Math.Sqrt(b*b - 4 * a * c))/(2*a);
            Console.WriteLine($"f = {f}");

            //4.
            double A = Math.PI *r*r;
            Console.WriteLine($"A = {A}");

        }
    }
}
