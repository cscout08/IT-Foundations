using System;
class session6ex1
{
    static void Main()
    {
        int[] numbers = new int[] { 10, 15, 20, 25, 30, 35 };
        Console.Write("Enter a number:");
        string str = Console.ReadLine();
        int num = int.Parse(str);  // convert input string into a number
        bool found = false;          // set a boolean flag
        foreach (int x in numbers) // code here) // use foreach to look for the number

        {
           
            if (num == x) // if number is found set found flag to true
            {
                found = true;
            }


        }
        if (found) // if true, i.e. found the number, say Found the Number
        {
            Console.WriteLine("Found Number");
        }
        else // if not true, did not find it, say Did not Find the Number
        {

            Console.WriteLine("Number is not found");
        }
        Console.ReadLine();
    }
}