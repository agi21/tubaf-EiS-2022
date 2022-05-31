
using System;

class Smartphone
{  
    private uint? _pin = null;
    private uint _tries = 0;
    private bool _isLocked = false;
    private const uint MaxTries = 3;

    private bool Authenticate()
    {
        if(_isLocked)
        {
            Console.WriteLine("Authentication failed - locked state");
            return false;
        }

        //wenn keine pin gestezt ist
        if(_pin is null)
        {
            Console.WriteLine("Authentication successful - no pin ");
            return true;
        }

        //letzter Fall Smartphone ist nicht gesperrt und pin ist gesetzt 
        do
        {
            Console.Write($"Enter Pin ({MaxTries - _tries} more tries): ");
            try
            {
                if(uint.Parse(Console.ReadLine()) == _pin)
                {
                    Console.WriteLine("Authentication successful");
                    _tries = 0;
                    return true;
                }else
                {
                    Console.WriteLine($"Wrong Pin!");
                    _tries++;
                }
            }
            catch
            {
                Console.WriteLine("Bad format! Pleae try again.");
                continue;
            }

        }while(_tries < MaxTries);

        Console.WriteLine("Phone is now locked!");
        _isLocked = true;
        return false;

    }


    //Methode zumändern der pin
    public void ChangePin()
    {
        string pinStr;
        Console.WriteLine("Authentication required!");

        if(this.Authenticate())
        {
            while(true)
            {
                Console.Write("Enter new pin: ");
                pinStr = Console.ReadLine();

                if(pinStr == "")
                {
                    _pin = null;
                    break;
                }
                else
                {
                    try
                    {
                        _pin = uint.Parse(pinStr);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Bad format! Please try again!");
                        continue;
                    }
                } 
            }            
            Console.WriteLine("New pin was set!\n");
        }
        else
        {
            Console.WriteLine("New pin is not possible!\n");
        }
    }


    public void Call()
    {
        Console.WriteLine("...");
    }

}