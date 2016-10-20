using System;

class Factorial
{
    static void Main()
    {

        Console.WriteLine("Please enter a number");

        string str;
        str = Console.ReadLine();

        int n;
        n = int.Parse(str);

        int i, fact;
        fact = n;
        for (i = n - 1; i >= 1; i--)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial is: " + fact);
        Console.ReadLine();

    }
}
