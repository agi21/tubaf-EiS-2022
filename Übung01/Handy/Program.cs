using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        //parameter
        var freeMinutes = 100.0;
        var pricePerMinutes = 0.099;
        var fixedPrice = 3.99;

        //Einlesen von Minuten und Tarif
        double minutes;
        char volumeSelection;
        try
        {
            Console.Write("Please enter your Minutes -> ");
            minutes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Please book your mobile data (S, M or L) -> ");
            volumeSelection = char.ToUpper(char.Parse(Console.ReadLine()));
        }
        catch
        {
            Console.WriteLine("Bad format");
            return;
        }

        //minuten validieren
        if(minutes < 0.0)
        {
            Console.WriteLine("Please enter a non-negative number of minutes.");
            return;
        }

        //Tarifpreis setzen
        double volumePrice;
        switch(volumeSelection)
        {
            case 'S':  volumePrice = 5.00; break;
            case 'M': volumePrice = 7.00; break;
            case 'L': volumePrice = 10.00; break;
            default: 
                Console.WriteLine("Invalid volume selection (only S, M or L)");
                return;
        }


        //zu zahlende Minuten berechnen
        var paidMinutes = Math.Max(0, Math.Ceiling(minutes-freeMinutes));

        //Gesamtkosten
        var price = fixedPrice + (paidMinutes * pricePerMinutes) + volumePrice;

        Console.WriteLine($"Price for {minutes} mins and volume selection {volumeSelection} : {price.ToString("f2")} EUR");


    }
}


