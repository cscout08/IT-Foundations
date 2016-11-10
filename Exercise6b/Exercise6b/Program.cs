using System;
class s6ex2
{
    /// <summary>
    /// 
    /// </summary>
    static void Main()
    {
        Console.Write(" Here is the multiplication for 5x5 table: ");   //creating a 5x5 matrix (or a table)
        Console.WriteLine();
        Console.WriteLine();
        int x; // declare an integer x to keep track of rows
        int y; // declare an integer y to keep track of columns

        // first for loop creates the rows
        for (x = 1; x <= 5; x++) //code here to create the x rows, marches vertically one row at a time  // Starting point, Ending Point, & Incrementor
        {
            // second for loop creates the columns
            for (y = 1; y <= 5; y++) // code here for creating y columns, marches horizontally as spaced below
            {
                int z = x * jjdy; // multiply x by y to create a value that gets placed into the table

                // Note: {0,6} indicates 6 spaces for parameter zero
                Console.Write("{0,6}", z);

            } // end of column loop
            Console.WriteLine(); // creating a line or a space between your rows 
        } // end of row loop

        Console.ReadLine();
    }
}
