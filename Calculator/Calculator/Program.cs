//A program that represent a calculator with 2 integer numbers 

using System;

class Program //class program with the main method 
{
    static void Main() //method main that represent the start of the program 
    {
        Console.WriteLine("\t\t\t\t\t\t\tCALCULATOR\n\n");

        bool continueOp = true; //variable to control the main loop 

        while (continueOp) //main loop to continue new operations 
        {
            int num1 = 0;
            int num2 = 0;
            bool validInput = false; //variable that verify the entered numbers 

            while (!validInput) //lopp to verify the entered numbers 
            {
                Console.WriteLine("Write one integer number");
                validInput = int.TryParse(Console.ReadLine(), out num1);
                if (!validInput)
                {
                    Console.WriteLine("Invalid Input. Try again.");
                }
            }

            validInput = false; //variable that verify the entered numbers

            while (!validInput) //lopp to verify the entered numbers 
            {
                Console.WriteLine("Write another integer number");
                validInput = int.TryParse(Console.ReadLine(), out num2);
                if (!validInput)
                {
                    Console.WriteLine("Invalid Input. Try again.");
                }
            }

            //Operations Menu 
            Console.WriteLine("Choose an option:\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n" +
                "5. Remainder\n");

            int option = 0;
            validInput = false;

            while (!validInput) //validation of the chosen option
            {
                validInput = int.TryParse(Console.ReadLine(), out option);
                if (!validInput || option < 1 || option > 5)
                {
                    validInput = false;
                    Console.WriteLine("Invalid Input. Try again.");
                }
            }

            switch (option) //cases with the different operations
            {
                case 1:
                    int add = num1 + num2;
                    Console.WriteLine("Result: " + add);
                    break;

                case 2:
                    int sub = num1 - num2;
                    Console.WriteLine("Result: " + sub);
                    break;

                case 3:
                    int mult = num1 * num2;
                    Console.WriteLine("Result: " + mult);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: division by 0 is not possible.");
                    }
                    else
                    {
                        double div = (double)num1 / num2;
                        Console.WriteLine("Result: " + div);
                    }
                    break;

                case 5:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: division by 0 is not possible.");
                    }
                    else
                    {
                        int rest = num1 % num2;
                        Console.WriteLine("Result: " + rest);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            //Question to the user if he want to make a new operation 
            Console.WriteLine("Do you want to make another operation? Respond yes or no.");
            string continueResponse = Console.ReadLine().ToLower();
            continueOp = (continueResponse == "yes");
        }
        Console.WriteLine("\n\nThank you for using the calculator. Have a good day!"); //Final message to the user 
    }
}







