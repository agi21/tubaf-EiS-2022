using System;

class Program
{
    static void Main(string[] args)
    {

        var alien1 = new Alien();
        alien1.Print();
            
        alien1.Description = "My first alien";
        alien1.RegID = 32;
        alien1.Power = 34.654;
        //alien.Cat = Category.Electro; //nicht möglich, da Cat kein Set 
        alien1.Print();

        var alien2 = new Alien("My second alien", 423, 324.3, Category.Thermo);
        alien2.Print(); 
            
    }
}