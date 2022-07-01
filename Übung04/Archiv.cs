using System;

class Archiv
{
    private static uint _nextID = 0;
    public uint ID {get;}
    public string Label {get;}
    public string Content {get;}

    public Archiv(string label, string content)
    {
        Label = label;
        Content = content;
        ID = _nextID++;
    }

    public void Print()
    {
        Console.WriteLine($"ID: {ID}, Label: {Label}, Content: {Content }");
    }
}