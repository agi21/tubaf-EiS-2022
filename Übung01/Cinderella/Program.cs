using System;

class Program
{
    static double[] GenerateDiameters()
    {
        // Zufallszahlengenerator erzeugen
        var rand = new Random();

        // Arraylänge n: 0 ... (n - 1) gültige Indizes
        var count = rand.Next(1500, 5000);
        var diameters = new double[count];

        for (var i = 0; i < count; i++)
        {
            diameters[i] = (3.25 * rand.NextDouble()) + 0.75;
        }

        return diameters;
    }

    // Fat-Arrow-Syntax
    static double CalculateNutVolume(double d) => (Math.PI * d * d * d) / 6;

    static void Main(string[] args)
    {
        // zufälliges Array erzeugen:
        var diameters = GenerateDiameters();


        var hazelnutCount = 0;
        var hazelnutVol = 0.0;

        var walnutCount = 0;
        var walnutVol = 0.0;

        foreach (var d in diameters)
        {
            // Nuss-Volumen
            var volume = CalculateNutVolume(d);

            // Nüsse klassifizieren
            if (d < 2)
            {
                hazelnutCount++;
                hazelnutVol += volume;
            }
            else
            {
                walnutCount++;
                walnutVol += volume;
            }
        }

        Console.WriteLine($"{ diameters.Length} nuts were seperated into {hazelnutCount} hazelnuts and {walnutCount} walnuts!");
        Console.WriteLine($"Average hazelnut volume: { hazelnutVol / hazelnutCount } cm^3");
        Console.WriteLine($"Average walnut volume: { walnutVol / walnutCount } cm^3");
    }
}