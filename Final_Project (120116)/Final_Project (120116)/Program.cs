using System;

struct Inventory
{

    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;

    //public object ItemID { get; internal set; }


}

class MyInventory

{

    public static void Main()

    {

        var numberOfItems = 0;
        var Inventory = new Inventory[80];



        while (true)


        {

            Console.Write("A)dd D)elete C)hange L)ist Q)uit:");
            var choice = Console.ReadLine();

            switch (choice)

            {

                case "A":
                case "a":

                    {
                        Console.Write("itemIDNo: ");
                        var itemIDNo = Console.ReadLine();
                        var itemID = int.Parse(itemIDNo);

                        Console.Write("sDescription: ");
                        var sDescription = Console.ReadLine();

                        Console.Write("dblPricePerItem: ");
                        var dblPricePerItem = Console.ReadLine();
                        var price = double.Parse(dblPricePerItem);

                        Console.Write("iQuantityOnHand: ");
                        var iQuantityOnHand = Console.ReadLine();
                        var quantity = int.Parse(iQuantityOnHand);

                        Console.Write("dblOurCostPerItem: ");
                        var dblOurCostPerItem = Console.ReadLine();
                        var cost = double.Parse(dblOurCostPerItem);

                        Console.Write("dblValueOfItem: ");
                        var dblValueOfItem = Console.ReadLine();
                        var value = double.Parse(dblValueOfItem);


                        Inventory[numberOfItems].itemIDNo = itemID;
                        Inventory[numberOfItems].sDescription = sDescription;
                        Inventory[numberOfItems].dblPricePerItem = price;
                        Inventory[numberOfItems].iQuantityOnHand = quantity;
                        Inventory[numberOfItems].dblOurCostPerItem = cost;
                        Inventory[numberOfItems].dblValueOfItem = value;
                    }
                    numberOfItems++;
                    break;

                case "D":
                case "d":

                    {

                        // Checking if the table is empty

                        if (numberOfItems == 0)

                        {

                            // If the table is empty, the Program will state "No Items"

                            Console.WriteLine("No Items");
                            break;

                        }

                        // Create a loop for the index variable 

                        Console.WriteLine("Item# ItemID     Description      Price    QOH      Cost    Value");

                        for (var index = 0; index < numberOfItems; index++)


                        // Program is writing the loop output


                        {
                      
                            Console.WriteLine("{0}.        {1,-8}    {2,-6}      {3,6:c}   {4,6}  {5,6:c}  {6,6:c}",

                            index + 1, Inventory[index].itemIDNo, Inventory[index].sDescription, Inventory[index].dblPricePerItem, Inventory[index].iQuantityOnHand, Inventory[index].dblOurCostPerItem, Inventory[index].dblValueOfItem);


                        }

                        Console.Write("Which item to remove (1 - {0})", numberOfItems);


                        var ItemNumberToDelete = Console.ReadLine();
                        var indexToDelete = int.Parse(ItemNumberToDelete);


                        // Squish the array from index to the end


                        for (var index = indexToDelete - 1; index < numberOfItems; index++)

                        {

                            // Just copy the item from the next index into the current index


                            Inventory[index] = Inventory[index + 1];

                        }

                        numberOfItems--;

                        break;

                    }

                case "C":
                case "c":

                    {

                        if (numberOfItems == 0)

                        {

                            Console.WriteLine("No items");
                            break;

             

                        }

                        Console.WriteLine("Item# ItemID     Description      Price    QOH      Cost    Value");

                        for (var index = 0; index < numberOfItems; index++)

                        {
                       
                            Console.WriteLine("{0}.        {1,-8}    {2,-6}      {3,6:c}   {4,-6}  {5,6:c}  {6,6:c}",

                            index + 1, Inventory[index].itemIDNo, Inventory[index].sDescription, Inventory[index].dblPricePerItem, Inventory[index].iQuantityOnHand, Inventory[index].dblOurCostPerItem, Inventory[index].dblValueOfItem);
                        }


                        Console.Write("Which items to change (1-{0})", numberOfItems);

                        var InventoryNumberToChange = Console.ReadLine();
                        var indexToChange = int.Parse(InventoryNumberToChange);

                        for (var index = indexToChange - 1; index < numberOfItems; index++)

                        {

                            Inventory[index] = Inventory[index + 1];

                        }


                        numberOfItems--;


                        Console.Write("itemIDNo: ");
                        var itemIDNo = Console.ReadLine();
                        var itemID = int.Parse(itemIDNo);

                        Console.Write("sDescription: ");
                        var sDescription = Console.ReadLine();

                        Console.Write("dblPricePerItem: ");
                        var dblPricePerItem = Console.ReadLine();
                        var price = double.Parse(dblPricePerItem);

                        Console.Write("iQuantityOnHand: ");
                        var iQuantityOnHand = Console.ReadLine();
                        var quantity = int.Parse(iQuantityOnHand);

                        Console.Write("dblOurCostPerItem: ");
                        var dblOurCostPerItem = Console.ReadLine();
                        var cost = double.Parse(dblOurCostPerItem);

                        Console.Write("dblValueOfItem: ");
                        var dblValueOfItem = Console.ReadLine();
                        var value = double.Parse(dblValueOfItem);



                        Inventory[numberOfItems].itemIDNo = itemID;
                        Inventory[numberOfItems].sDescription = sDescription;
                        Inventory[numberOfItems].dblPricePerItem = price;
                        Inventory[numberOfItems].iQuantityOnHand = quantity;
                        Inventory[numberOfItems].dblOurCostPerItem = cost;
                        Inventory[numberOfItems].dblValueOfItem = value;



                        numberOfItems++;


                        break;
                    }



                case "L":
                case "l":
                    {
                        if (numberOfItems == 0)
                        {
                            Console.WriteLine("No items");
                        }

                        Console.WriteLine("Item# ItemID     Description      Price    QOH      Cost    Value");

                        for (int index = 0; index < numberOfItems; index++)
                        {
                           
                            Console.WriteLine("{0}.        {1,-8}    {2,-6}      {3,6:c}   {4,-6}  {5,6:c}  {6,6:c}",

                            index + 1, Inventory[index].itemIDNo, Inventory[index].sDescription, Inventory[index].dblPricePerItem, Inventory[index].iQuantityOnHand, Inventory[index].dblOurCostPerItem, Inventory[index].dblValueOfItem);
                        }

                        break;

                    }



                case "Q":
                case "q":


                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        var quit = Console.ReadLine();

                        if (quit == "y")
                        {
                            Environment.Exit(0);  //as long as it is not 5, the process is not breaking	
                        }
                        break;

                    }

                default:
                    {
                        Console.WriteLine("Invalid option [{0}]", choice);
                        break;
                    }
            }
        }
    }
}

