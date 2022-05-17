using System;

//Augabe etwas ausführlicher
//Ausgabe und damit Code reduzierbar 

class Program
{
    static void Main(string[] args)        
    {
        var rand = new Random();
        int points = 0;
        int dice;
        int win;
        int case1 = 0;
        int case2 = 0;
        int case3 = 0;
        int case4 = 0;

        for (int i = 1; i <=1000; i++){

            //Ausgabe aktuelles Spiel
            Console.WriteLine($"Spiel {i}:");
            Console.Write("\t");

            for(int j =1; j<= 3; j++){
                dice = rand.Next(1, 7);
                points += dice;

                //Ausgabe des aktuellen Wurfs
                Console.Write($"Wurf {j}: {dice}\t");
            }
            
            //Punkte
            Console.WriteLine($"\n\tPunkte: {points}");

            //Punkte klassifizieren
            switch (points)
            {
                case 16:
                    win = 5;
                    case2++;
                    break;
                case 17:
                    win = 10;
                    case3++;
                    break;
                case 18:
                    win = 100;
                    case4++;
                    break;
                default:
                    win = 0;
                    case1++;
                    break;
            }

            Console.WriteLine($"\tGewinn: {win}\tAuszahlung: {win -1}");

            points = 0;
        }

        Console.WriteLine("\nÜbersicht: ");
        Console.WriteLine($"\t3-15 Punkte:\t{case1} Gesamtgewinn: {case1 * -1}");
        Console.WriteLine($"\t16 Punkte:\t{case2} Gesamtgewinn: {case2 * 4}");
        Console.WriteLine($"\t17 Punkte:\t{case2} Gesamtgewinn: {case3 * 9}");
        Console.WriteLine($"\t18 Punkte:\t{case4} Gesamtgewinn: {case4 * 99}");
        Console.WriteLine($"Gesamtgewinn/verlust: {(case1 * -1) + (case2 * 4) + (case3* 9) + (case4 *99)}");
    }
}
