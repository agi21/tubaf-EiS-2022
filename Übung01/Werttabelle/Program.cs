using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        //Parameter
        double a, e, s;

        //dynamisches Einlesen
        try
        {
            Console.Write("Interval start -> ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Interval end -> ");
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Step size -> ");
            s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        catch
        {
            Console.WriteLine("Bad format!");
            return;
        }

        //Validierung der Eingaben
        if(e < a)
        {
            Console.WriteLine("Start of intervall most be <= its end");
            return;
        }

        if(s <= 0)
        {
            Console.WriteLine("Step size must be above 0.");
            return;
        }

        //Tabellenkopf ausgeben
        Console.WriteLine("      x      |      y       ");
        Console.WriteLine("----------------------------");

        //Startwert festlegen
        var x = a;

        //Tabbelnkörper in Schleife ausgeben/ Werte berechnen
        while(x <= e)
        {
            //x ausgeben
            Console.Write("{0,13:f7}|", x);

            //Nenner berechnen
            var denom = ((x+2)*(x-1)*(x-1));

            //y berechnen bze. Singularität feststellen
            if(Math.Abs(denom) <= 1.0e-10)
            {
                Console.WriteLine("Sing.");
            }
            else
            {
                var y = ((3*x)-6) / denom;
                Console.WriteLine("{0:f7}",y);
            }
            
            //X erhöhen 
            x += s;
        }
    }
}

