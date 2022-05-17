using System;

class Program
{
    static void Main(string[] args)
    {
            string[] platzierung = new string[] {"Marte Olsbu Röiseland", "Elvira Öberg", "Lisa Theresa Hauser", "Hanna Öberg", "Anais Chevalier-Bouchet",
                                                    "Denise Herrmann", "Dzinara Alimbekava", "Justine Braisaz-Bouchet", "Dorothea Wierer", "Marketa Davidova"};
            Console.WriteLine("Platzierung | Name");
            Console.WriteLine("------------|------------------------------");

    
            for(int j = 0; j< platzierung.Length; j++)
            {
                Console.WriteLine("{0,-12}|{1,-30}", j+1, platzierung[j]);
            }

            int i; 
            try{
                Console.Write("\nEingabe Platz: ");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine($"Auf Paltz {i} ist {platzierung[i-1]}\n");
            }catch{
                Console.WriteLine("Falscher Input");
                return;
            }
    }
}

