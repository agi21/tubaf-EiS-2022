using System;

namespace TemperatureCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //fixed input 
            float fahrenheit, celsius;
            celsius = 0;
            // 9/5 liefert 1 
            // wird als int interpretiert -> Nachkommastellen werden abgeschnitten
            // -> 9f/5 oder 1.8f
            // 9.0/8 nicht möglich, da 9.0 standartmäßig als double interpretiert wird
            fahrenheit = 1.8f * celsius + 32;
            Console.WriteLine("{0} Celsius entspricht {1} Fahrenheit", celsius, fahrenheit);

            //dynamic input
            Console.WriteLine("Celsius: ");
            celsius = Convert.ToSingle(Console.ReadLine());
            fahrenheit = 1.8f * celsius + 32;
            //case-sensitiv
            // d.h. Groß- und Kleinschreibung beachten!
            Console.WriteLine("Fahrenheit: {0}", fahrenheit); 
        }
    }
}
