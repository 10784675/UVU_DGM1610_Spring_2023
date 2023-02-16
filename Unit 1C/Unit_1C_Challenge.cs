using System;

public class Program
{
    public void Main()
    {
        string[] cars = {"Nissan", "Kia", "Lexus", "Honda", "Ford", "BMW"};
        Console.WriteLine(cars.Length);
        foreach(var car in cars) {
            Console.WriteLine("I love my" + car + ".");
            
        }
    }

    public static void Main()
    {
        string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
        playerTypes[1] = "Queen";
        foreach(var playertype in playerTypes) {
            Console.WriteLine(playertype);
        }
    }

    public void Main()
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    public void Main()
    {
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 15);
    }

    public void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void Main()
    {
        for (int i = 0; i <= 10; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }

    public void Main()
    {
        string[] color = {"Purple", "Blue", "Yellow", "Green"};
        foreach (string i in color)
        {
            Console.WriteLine(i);
        }
    }

    public void Main()
    {
        string[] colors = {"Purple", "Blue", "Yellow", "Green"};
        Console.WriteLine(colors[0]);
    }

    public void Main()
    {
        string[] colors = {"Purple", "Blue", "Yellow", "Green"};
        colors[0] = "Red";
        Console.WriteLine(colors[0]);
    }

     public void Main()
    {
        string[] colors = {"Purple", "Blue", "Yellow", "Green"};
        Console.WriteLine(colors.Length);
    }

     public void Main()
    {
        string[] colors = {"Purple", "Blue", "Yellow", "Green"};
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);
        }
    }

     public void Main()
    {
        string[] colors = {"Purple", "Blue", "Yellow", "Green"};
        foreach (string i in colors)
        {
            Console.WriteLine(i);
        }
    }
}