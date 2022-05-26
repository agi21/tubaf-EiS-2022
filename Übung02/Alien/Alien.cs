using System;


class Alien
{
    //wichtig: Kapselung: interner Status soll intern gehalten werden

    /*
    private string _description;

    //Properties (Methoden mit feldähnlicher Zugriffssyntax)
    public string Description
    {
        //gibt oben angegebenen Datentyp zurück
        get => _description;

        //value existiert immer als Übergabeparameter 
        set => _description = value; 
        
    }
    */

    //automatische Propertie (bei Standart Get und Set wie oben)
    public string Description {get; set; } = "";
    public uint RegID{get; set; } = 42;
    public Category Cat {get; } = Category.None;
    public double Power {get; set; } = 0;

    public void Print()
    {
            Console.Write($"Description: '{Description}',");
            Console.Write($" RegID: {RegID},");
            Console.Write($" Category: {Cat},");
            Console.WriteLine($" Power: {Power}");
    }

    
    //Konstruktor: besondere Methode
    //wird beim Anlegen einer neuen Instanz mit new aufgerufen
    public Alien() {}

    //Überladung möglich: gleicher Name mit unterschiedlichen Parametern
    public Alien(Category category)
    {
        Cat = category;
        Description = "";
    }

    public Alien(string description, uint regId, double power, Category category)
    {
        Cat = category;
        Description = description;
        RegID = regId;
        Power = power;
    }

    
}

enum Category 
{
    Thermo,
    Electro,
    None
}
