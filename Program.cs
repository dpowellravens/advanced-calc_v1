using System.Reflection.Emit;

namespace AdvancedCalculator;

public class Program
{
    static string calculatorChoice;
    public static string userNumInput1;
    public static string userNumInput2;
    public static string inputType;
    public static string operand;
    public static bool continueAnswerBool = true;
    public static bool success;

    public static string userDollarAmt;
    public static string userPercent;

    // Main Method
    static void Main(String[] args)
    {
        ChooseCalcType(); //Choose either Basic or Tip

        while (continueAnswerBool) //Do this if they choose to continue with the calculation.
        {
            ProcessUserInputs();
        }
        
    }
    public static void ProcessUserInputs()
    {
        string? continueAnswer;
        switch (calculatorChoice) //passes value from previous method
        {
            case "Basic":
                    BasicCalc.CaptureInput("First");
                    BasicCalc.CaptureInput("Second");
                    BasicCalc.CaptureInput("Operand");
                    
                    if (success) //calculation was successful; therefore check to see if they want to do another one.
                    {
                        Console.WriteLine("Would you like to do another calculation? Type Y if you would like to continue;" +
                                          " otherwise type any other letter/combo to exit the program.");
                        continueAnswer = Console.ReadLine();
                        continueAnswerBool = continueAnswer is "Y" or "y";

                        //Check to see if they want to continue
                        switch (continueAnswerBool)
                        {
                            case true:
                                Console.WriteLine("Woo hoo! Let's continue!!"); 
                                //reset values
                                userNumInput1 = "";
                                userNumInput2 = "";
                                operand = "";
                                break;
                                
                            default:
                                Console.WriteLine("Thank you for your time. Goodbye!!");
                                break;
                        }

                    }
                    break;

            case "Tip":
                
                TipCalc.CaptureInput("DollarAmount");
                TipCalc.CaptureInput("Percentage");
                
                if (success) //calculation was successful; therefore check to see if they want to do another one.
                // {
                Console.WriteLine("Would you like to do another calculation? Type Y if you would like to continue;" +
                                  " otherwise type any other letter/combo to exit the program.");
                continueAnswer = Console.ReadLine();
                continueAnswerBool = continueAnswer is "Y" or "y";

                switch (continueAnswerBool)
                {
                    case true:
                        Console.WriteLine("Woo hoo! Let's continue!!");
                        break;
                    
                    default:
                        Console.WriteLine("Thank you for your time. Goodbye!!");
                        break;
                }

                break;
        }
    }

    static void ChooseCalcType()
    {
        while (calculatorChoice != "Basic" && calculatorChoice != "Tip")
        {
            Console.WriteLine("Choose 1 for Basic and 2 for Tip");
            var calcType = Console.ReadLine();
            switch (calcType)
            {
                case "1":
                    Console.WriteLine("You chose the Basic Calculator");
                    calculatorChoice = "Basic";
                    break;

                case "2":
                    Console.WriteLine("You chose the Tipping Calculator.");
                    calculatorChoice = "Tip";
                    break;

                default:
                    Console.WriteLine("You must enter either 1 or 2. Please try again.");
                    break;
            }
        }

    }
}
