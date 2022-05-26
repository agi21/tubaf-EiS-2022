using System;
using System.Threading;

class Program
{

    //Methode, die ganze ZK in Morsezeichen überführt 
    static void MorseString(string s)
    {
        foreach(var c in s)
        {
            //c ist char -> können MorseCode  drauf aufrufen 
            //generieren Morsezeichen und leiten diese an MorseChar weiter 
            MorseChar(MorseTable.GetMorseCode(c));
        }
    }

    //Methode, die Konsole für eine bestimnmte Zeit blinken lässt
    static void Flash(int msec)
    {
        //Konsole auf ieine Frabne setzen und dann wieder auf schwarz
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        //Konsole muss geleert werden damit ganzer Hintergrund gezeichnet wird

        //warten einen Moment => Konsole soll für bestimmte Zeit gefärbt bleiben
        Thread.Sleep(msec);

        //setzt Konsole wieder auf ursprüngliche Farbe 
        //auch bei heller Konsole wieder auf schwarz setzen
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();  
    }


    //bekommt kette von Punkten, Strichen und Leerezeichen 
    static void MorseChar(string symbols)
    {
        foreach(var symbol in symbols)
        {
            //je nach Symbol soll Console für eine bestimmte Ziet blinken
            //Aufruf der FlaH-methode
            switch (symbol)
            {
                case '.': Flash(150); break; //kurz leuchten 
                case '-': Flash(3*150); break; //Lang leuchten
                case ' ': Thread.Sleep(1000); break;//zwischen 2 Wörtern etwas länger warten 
                default: // können exception werfen
                    throw new FormatException("Unexpected morse symbol");
            }    

            //zwischen zwei Zeichen warten
            Thread.Sleep(150);
        }
    }

  
    static void Main(string[] args)
    {
        Console.Write("To Morse: ");
        MorseString(Console.ReadLine());
    }

}