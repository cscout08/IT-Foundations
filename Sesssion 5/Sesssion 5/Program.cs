using System;

    class Average  // Write a program that calculates the average of the numbers given by the users 
    {
    static void Main()
    {


        // define a variable for summation

        float fsum = 0.0f;

        // define a variable for average
        float favg;

        {
            // start up the for loop: allow for 10 entries by the user

            for (int x = 1, x <= 10; x++) ;

            // ask the user to give you a number

            Console.WriteLine("Please enter number {0} of 10:", x);

            // read and store the given number // Parse allows you to convert string to numberic

            string strnum = Console.ReadLine()

            // parse allows you to convert string to numberic

            float n = float.Parse(strnum);

            // sum up the number as given sequentially 

            fsum = fsum + n

        }  // end of the for loop

        // after suming them up within the loop, then we wil find the average

        favg = fsum / 10;


           // show the result on the console
       
        Console.ReadLine("The average of the given number is {0}", favg);

        // holding up the console to see the result

        Console.ReadLine();


        }
  
}
