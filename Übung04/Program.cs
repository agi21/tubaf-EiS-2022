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
    }
}

