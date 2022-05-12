using System;

class Program
{
    static void Main(string[] args)
    {
        uint year;
        string yearString = "";

        //Endlosschleife 
        //fußgesteurte do-while Schleife
        do
        {
            Console.Write("Year -> ");
            yearString = Console.ReadLine();

            //Abbruchbedingung
            if(yearString.Length == 0)
            {
                Console.WriteLine("The end!");
                return;
            }

            //sonst in uint parsen
            try
            {
                year = uint.Parse(yearString);
            }
            catch
            {
                Console.WriteLine("Bad format");
                continue;
            }

            //"Berechnung" durchführen
            bool isLeapYear = (year % 4 == 0) 
                            && (year % 100 != 0) 
                            || (year % 400 == 0);

            Console.WriteLine($"The year {year} is a leap year: {isLeapYear}");

        }while (true);
    }
}

