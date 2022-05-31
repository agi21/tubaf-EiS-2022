using System;

struct Size
{
    private double _width;
    private double _height;


    public double Width
    {
        get => Width;
            
        set 
        {
            if(value < 0)
            {
                throw new ArgumentException("invalid value");
            }else
            {
                _width = value;
            }
        }
    }

    public double Height
    {
        get => Height;
        set 
        {
            if(value < 0)
            {
                throw new ArgumentException("invalid value");
            }
            else
            {
                _height = value;
            }            
        }
    }

    public Size(double width, double height)
    {
        if(width < 0 || height < 0)
        {
            throw new ArgumentException("invalid value");
        }
        _height = height;
        _width = width;
    }

    public void Print()
    {
        Console.WriteLine($"Width = {_width}, Height = {_height}");
    }
}



class Program
{
    static void Main(string[] args)
    {
        var s1 = new Size();
        s1.Print();

        try 
        {
            var s2 = new Size(23.1,432);
            s2.Print();
            s2.Width = -3;
        }
        catch
        {
            Console.WriteLine("Bad format!");
        }
        
    }
    
}
