using System;
using System.Net;

namespace AdvancedCalculator;

public class BasicCalc : Program
{
    //public static string userNumInput;
    static string operand;
    static double convertInput;
    static bool invalid = true;

    public static void AcceptUserInputs(string inputOrder)
    {
        while (invalid) //Do this while user keeps inputting invalid data.
        
        {
            //Accept user inputs.

            switch (inputOrder)
            {
                case "First":
                    Console.WriteLine(invalid);
                    Console.WriteLine("Please enter your 1st number and hit return.");
                    userNumInput = Console.ReadLine();
                    Console.WriteLine($"User input is {userNumInput}");
                    break;

                case "Second":
                    Console.WriteLine(invalid);
                    Console.WriteLine("Please enter your 2nd number and hit return.");
                    userNumInput = Console.ReadLine();
                    Console.WriteLine($"User input is {userNumInput}");
                    break;
            }

            //Checking for an invalid number/integer and NULL
            bool isNumberParsed = double.TryParse(userNumInput, out convertInput);
            Console.WriteLine($"Boolean is {isNumberParsed}");
            if (!isNumberParsed)
            {
                Console.WriteLine("You entered a null or invalid number. Please try again.\n");
                Console.WriteLine("Invalid");
                Console.WriteLine(isNumberParsed);
                //Console.WriteLine($"User input is {userNumInput}");
                //Console.WriteLine($"Converted input is {convertInput}");
            }
            if (isNumberParsed)
            {
                //Console.WriteLine(inputOrder);
                invalid = false;
                Console.WriteLine("Valid");
                Console.WriteLine(isNumberParsed);
                //Console.WriteLine($"User input is {userNumInput}");
                //Console.WriteLine($"Converted input is {convertInput}");
            }


        }

    }
}    