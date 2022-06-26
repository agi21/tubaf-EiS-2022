using System;
using System.Threading;

class Computer
{
    public string User{get; private set;}
    public bool IsCrashed {get; private set;}
    private static Random _rand = new Random();

    //Konstuktor
    public Computer()
    {
        User = "Administrator";   
        IsCrashed = false;
        _ipAddress = IPTools.LocalHost; //-> 23 

    }

    //Methoden
    public void ChangeUser(string newUser)
    {
        Console.WriteLine("Logging out ...");
        Thread.Sleep(1000);
        Console.WriteLine($"Logging in as {newUser}");
        User = newUser;
    }

    public void SaveFile(string path, string name)
    {
        if(IsCrashed)
        {
            throw  new InvalidOperationException("Files can not be saved - crashed state");
        }

        var fullPath = System.IO.Path.Combine(path, name);
        Console.WriteLine($"Saving file: {fullPath}");

        if(_rand.Next(0,4) == 3)
        {
            IsCrashed = true;
            Console.WriteLine("Computer has crashed while saving file!");

            throw new InvalidOperationException("Crash!");
        }
    }

    public void SaveFile(string name)
    {
        SaveFile("Desktop", name);
        
    } 

    public void Reboot()
    {
        Console.WriteLine("Rebooting ...");
        Thread.Sleep(3000);
        Console.WriteLine("Reboot successful!");

        IsCrashed = false;
    }

}