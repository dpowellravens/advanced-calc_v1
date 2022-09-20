using System;
using System.Net;

namespace AdvancedCalculator;

public class BasicCalc : Program
{
    string userInput;
    string operand;
    static double convertInput;
    string input;
    
    
    static bool invalid = true;
    
    public static void AcceptUserInputs(string inputOrder)
    {
        //Accept user inputs.
        if (inputOrder == "First")
        {
            Console.WriteLine("Please enter your 1st number and hit return.");
            string userInput = Console.ReadLine();
            ValidateUserInputs(userInput, "First");
        }

        if (inputOrder == "Second")
        {
            Console.WriteLine("Please enter your 2nd number and hit return.");
            string userInput = Console.ReadLine();
            ValidateUserInputs(userInput, "Second");
        }
        //Console.WriteLine(ValidateUserInputs(userInput));
    }

    public static void ValidateUserInputs(string userInput, string inputOrder)
    {
        
        while (invalid) //Do this while user keeps inputting invalid data.
        {
            //Checking for an invalid number/integer and NULL
            bool isNumberParsed = double.TryParse(userInput, out convertInput);
            if (!isNumberParsed || string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("You entered a null or invalid number. Please try again.\n");
                //Console.WriteLine(inputOrder);
                AcceptUserInputs(inputOrder);
                //Console.WriteLine("HEY");
            }
            else
            {
                //Console.WriteLine(inputOrder);
                invalid = false;
            }
        }

        // //Basic calculator method
        // public static double PerformBasicCalc(double inputOne, double inputTwo, string operand)
        // {
        //     //Do the calculations based on operator selected.
        //     double calculation = 0;
        //     switch (operand)
        //     {
        //         case "+":
        //
        //             calculation = inputOne + inputTwo;
        //             Console.WriteLine($"{inputOne} + {inputTwo} = {calculation}");
        //             break;
        //
        //         case "-":
        //             calculation = inputOne - inputTwo;
        //             Console.WriteLine($"{inputOne} - {inputTwo} = {calculation}");
        //             break;
        //
        //         case "*":
        //             calculation = inputOne * inputTwo;
        //             Console.WriteLine($"{inputOne} * {inputTwo} = {calculation}");
        //             break;
        //
        //         case "/":
        //             calculation = inputOne / inputTwo;
        //             Console.WriteLine($"{inputOne} / {inputTwo} = {calculation}");
        //             break;
        //     }
        //
        //     return calculation;
        // }

    }
}