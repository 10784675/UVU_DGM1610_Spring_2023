using System;

public class Program
{
    public void Main()
    {
        string[] cars = {"Mustang", "Camaro", "HellCat", "Corvette", "Viper", "McLaren"};
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
        while (i < 5)
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
        } while (i < 5);
    }

    public void Main()
    {
        for (int i = 0; i < 5; i++)
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
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }

    public void Main()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        Console.WriteLine(cars[0]);
    }

    public void Main()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        cars[0] = "Opel";
        Console.WriteLine(cars[0]);
    }

     public void Main()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        Console.WriteLine(cars.Length);
    }

     public void Main()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }

     public void Main()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }
}