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
        //comp.SaveFile("home", "test.txt");
        //comp.SaveFile("test.txt");
        
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

        //test IpTools
        Console.WriteLine($"Initial IPv4 address: {comp.IPAddress}");
        comp.IPAddress = "192.168.0.1";
        Console.WriteLine($"new IPv4 address: {comp.IPAddress}");

        comp.IPAddress = "ffee:ddcc:bbaa:9988:7766:5544:3322:1100";
        Console.WriteLine($"new IPv6 address: {comp.IPAddress}");

        comp.CreateArchive("Absatz von Smartphones", "173.5, 304.7, 494.5, 725.3, 1019.4, 1301.7, 1437.6, 1469, 1465.5, 1402.6, 1372.6, 1280", out var a1);
        comp.CreateArchive("Impfbereitschaft", "7, 6, 11, 75", out var a2);

        a1.Print();
        a2.Print();

    }
}

