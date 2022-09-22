using System;
using System.Net;

namespace AdvancedCalculator;

public class BasicCalc : Program
{
    //public static string userNumInput;
    public static string operand;
    public static double convertInput1;
    public static double convertInput2;
    static bool isDivisorZero;
    static bool continueAnswerBool = true;

    public static void ProcessInputs(string inputOrder)
    {
        bool invalid = true;
        bool isNumberParsed = false;

        while (invalid) //Do this while user keeps inputting invalid data.
        {
            //Accept user inputs.
            
            switch (inputOrder)
            {
                case "First":
                    //Console.WriteLine(invalid);
                    Console.WriteLine("Please enter your 1st number and hit return.");
                    userNumInput1 = Console.ReadLine();
                    isNumberParsed = double.TryParse(userNumInput1, out convertInput1);
                    break;

                case "Second":
                    //Console.WriteLine(invalid);
                    Console.WriteLine("Please enter your 2nd number and hit return.");
                    userNumInput2 = Console.ReadLine();
                    isNumberParsed = double.TryParse(userNumInput2, out convertInput2);
                    isDivisorZero = convertInput2 == 0; //
                    break;
                
                case "Operand":
                    Console.WriteLine(invalid);
                    Console.WriteLine("Please enter your math operator and hit return.");
                    operand = Console.ReadLine();
                    
                    //isDivisorZero = convertInput2 == 0; //
                    break;
            }
                //Checking for an invalid number/integer and NULL
                if ((inputOrder == "First" || inputOrder == "Second") && !isNumberParsed)
                {
                    Console.WriteLine("You entered a null or invalid number. Please try again.\n");
                    Console.WriteLine(inputOrder);
                    continue;
                }

                if (inputOrder == "Operand" && (string.IsNullOrEmpty(operand) || 
                    ((operand != "+") && 
                     (operand != "-") && (operand != "/") 
                     && (operand != "*"))))
                    {
                        Console.WriteLine("You entered a NULL value or invalid operator. Please try again.\n");
                        continue;
                    }
                
                if ((operand == "/") && (isDivisorZero)) //Checks for 0 in the divisor.
                {
                    Console.WriteLine("You are not allowed to divide by 0. Please try again.\n");
                    continue;
                }
                else
                {
                    invalid = false;
                }

        }
        
    }

    static void CalculateBasic(double convertedInput1, double convertedInput2, string operand)
    {
        //Do the calculations based on operator selected.
        //operand = null;
        switch (operand)
        {
            case "+":
        
                var additionCalculation = convertInput1 + convertInput2;
                Console.WriteLine($"{convertInput1} + {convertInput2} = {additionCalculation}");
                break;
        
            case "-":
                var subtractionCalculation = convertInput1 - convertInput2;
                Console.WriteLine($"{convertInput1} - {convertInput2} = {subtractionCalculation}");
                break;
        
            case "*":
                var multiplicationCalculation = convertInput1 * convertInput2;
                Console.WriteLine($"{convertInput1} * {convertInput2} = {multiplicationCalculation}");
                break;
        
            case "/":
                var divisionCalculation = convertInput1 / convertInput2;
                Console.WriteLine($"{convertInput1} / {convertInput2} = {divisionCalculation}");
                break;
        }

        Console.WriteLine("Would you like to continue? Y or N?");
        var continueAnswer = Console.ReadLine();

        //Checking to see if they want to continue
        continueAnswerBool = continueAnswer is "Y" or "y";
    }
}    