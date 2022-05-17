using System;


class Program
{
    static void Main(string[] args)
    {

        double max =0;
        string smax = "beide";

        double[] kittsNevis = new double[10];
        double[] niue = new double[10];

        var rand = new Random();

        for (int i = 0; i<10; i++)
        {
            niue[i] = rand.NextDouble()*10;
            kittsNevis[i] =  rand.NextDouble()*10;
        }
        int year = 2022;
        double averageKitNev = 0;
        double averageNiue = 0;
        

        for(int i = 0; i <10; i++)
        {
            if(niue[i] == kittsNevis[i])
            {
                Console.WriteLine($"größter Ausstoß: 'Niue' und 'St. Kitts und Nevis' im Jahr {year-i}");
            }else if(niue[i] < kittsNevis[i])
            {
                Console.WriteLine($"größter Ausstoß: 'St. Kitts und Nevis' im Jahr {year -i}");
                if (kittsNevis[i] > max)
                    {
                        max = kittsNevis[i];
                        smax = "St. Kitts und Nevis";
                    }
            }else if(niue[i] > kittsNevis[i])
            {
                Console.WriteLine($"größter Ausstoß: 'Niue' im Jahr {year-i}");
                if (niue[i] > max)
                    {
                        max = niue[i];
                        smax = "Niue";
                    }
            }

            averageKitNev += kittsNevis[i];
            averageNiue += niue[i];
    

        }

        averageKitNev = averageKitNev / 10;
        averageNiue = averageNiue / 10;


        Console.WriteLine($"10 Jahre Durchschnitt St. Kitts und Nevis: {averageKitNev:f2}");
        Console.WriteLine($"10 Jahre Durchschnitt Nevis: {averageNiue:f2}");

        Console.WriteLine($"max. Austoß: {max} von {smax}");



    }
}



