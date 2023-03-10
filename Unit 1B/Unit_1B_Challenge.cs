using System;

public class Program
{
    public void Main ()
    {
        Console.WriteLine("Welcome");
        DoMath(10, 4);
        DoMath(20, 7);
        DoMath(30, 15);
        Compare(4,3);
        Compare(3,4);
        CheckPassword("Seven0F9");
        CheckPassword("OU812");
    }

    public void DoMath (int value, int value2)
    {
        var number = value + value2;
        Console.WriteLine(number);
    }

    public void Compare (int value, int value2)
    {
        if(value > value2)
        {
            Console.WriteLine("True, the first greater.");
        }
        else
        {
            Console.WriteLine("False, the second is greater.");
        }
    }

    public void CheckPassword (string password)
    {
        if(password == "OU812")
        {
            Console.WriteLine("Correct Password");
        }
        else
        {
            Console.WriteLine("Incorrect Password.");
        }
    }
}