using System;

class Assignment4

{

    static void Main()

    {
        Console.WriteLine("Please enter a number");

        string str = Console.ReadLine();

        3int n = int.Parse(str);  // Gets numbers to calculate

        int Max;
        int Fact;


        Max = n;
        Fact = 1;


        for (int Index = 1; Index <= Max; Index++)

        {
            Fact = Index * Fact;

            Console.WriteLine("Factorial is {0}", Fact);
        }
        Console.ReadLine();
    }
}