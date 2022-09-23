using System.Reflection.Emit;

namespace AdvancedCalculator;

public class Program //base class
{
    static string calculatorChoice;
    public static string userNumInput1;
    public static string userNumInput2;
    public static string userDollarAmt;
    public static string userPercent;
    //public static string inputType;
    public static string operand;
    public static bool continueAnswerBool = true;
    public static bool success;

    // Main Method
    static void Main(String[] args)
    {
        Console.WriteLine("This is my Advanced Coding Calendar. You can do basic mathematical calculations" +
                          " as well as tip calculations.");
        
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
                                Console.WriteLine("Woo hoo! Let's continue!!\n"); 
                                
                                //reset values for next run if they continue
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
                        Console.WriteLine("Woo hoo! Let's continue!!\n");
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
            Console.WriteLine("Enter 1 for Basic and 2 for Tip:");
            var calcType = Console.ReadLine();
            switch (calcType)
            {
                case "1":
                    Console.WriteLine("You chose the Basic Calculator \n");
                    calculatorChoice = "Basic";
                    break;

                case "2":
                    Console.WriteLine("You chose the Tipping Calculator.\n");
                    calculatorChoice = "Tip";
                    break;

                default:
                    Console.WriteLine("You must enter either 1 or 2. Please try again.\n");
                    break;
            }
        }

    }
}
