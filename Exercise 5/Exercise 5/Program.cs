using System;
class Average
{
    static void Main()
    {
        float fsum = 0.0f;
        float favg;
        for (int x = 1; x <= 10; x++)
        {
            Console.Write("Please enter number {0} of 10:", x);
            string strnum = Console.ReadLine();
            float n = float.Parse(strnum);
            fsum = fsum + n;
        }
        favg = fsum / 10;
        Console.WriteLine("The average of the given numbers is {0}", favg);
        Console.ReadLine();
    }

}