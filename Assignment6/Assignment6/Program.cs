using System;
namespace ConsoleApplication1
{

    // Set-up a Structure 

    public struct Pet
    {

        // Define the String Variables 

        public string Name;
        public string TypeOfPet;
    }

    // Defining the class, which acts like the blueprint for the program

    class Program
    {

        static void Main()
        {

            // Set-up an array for inventory
            // For this program, the Array will have a max of 10 spaces

            var numberOfPets = 0;
            var pets = new Pet[10];

            // Create a while loop that allows user to cycle through the program

            while (true)

            // Set-up options for the users to choose from by using Console.Write

            {
                Console.Write("A)dd D)elete L)ist pets:");
                var choice = Console.ReadLine();

                // Create a switch to move between the different options 

                switch (choice)

                {

                    // Allows for typing in either lower or uppercase for the various options 

                    case "A":
                    case "a":

                        {

                            Console.Write("Name :");
                            var name = Console.ReadLine();
                            Console.Write("Type of pet :");
                            var typeOfPet = Console.ReadLine();

                            // Always add the pet at the end of the array

                            // Assigning values (Name, TypeOfPet) to the array Pets 

                            pets[numberOfPets].Name = name;
                            pets[numberOfPets].TypeOfPet = typeOfPet;
                            numberOfPets++;
                            break;

                        }
                    case "D":
                    case "d":
                        {

                            // Checking if the array is empty. If the array is empty, the Program will state "No Pets"

                            if (numberOfPets == 0)

                            {
                                Console.WriteLine("No pets");
                                break;
                            }

                            //Creates a loop for the index variable 

                            for (var index = 0; index < numberOfPets; index++)

                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets);
                            var petNumberToDelete = Console.ReadLine();
                            var indexToDelete = int.Parse(petNumberToDelete);

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++)

                            {

                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];

                            }
                            // We have one less pet

                            numberOfPets--;
                            break;
                        }
                    case "L":
                    case "l":
                        {

                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets");
                            }

                            for (int index = 0; index < numberOfPets; index++)

                            {

                                // Array to display all items that have been indexed 

                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }
                            break;
                        }
                    default:
                        {

                            // Program will break if user doesn't select a valid option

                            Console.WriteLine("Invalid option [{0}]", choice);
                            break;
                        }
                }
            }
        }
    }
}