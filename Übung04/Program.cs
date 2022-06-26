using System;

class Program
{
    static void Main(string[] args)
    {
        
        Computer comp = new Computer();
        Console.WriteLine($"User: { comp.User}");

        //Test ChangeUser Methode
        comp.ChangeUser("Anne");
        Console.WriteLine($"User: { comp.User}");

        //test SaveFile
        comp.SaveFile("home", "test.txt");
        comp.SaveFile("test.txt");
        
/*
        while(true)
        {
            try
            {
                comp.SaveFile("test.txt");
            }
            catch (InvalidOperationException)
            {
                comp.Reboot();
            }
        }
*/

    }
}

