namespace AdvancedCalculator;

public class Program
{
    static string calculatorChoice; 
    static string userInput;
    static double convertUserInput;
    
    // Main Method
    static void Main(String[] args)
    {
        ChooseCalcType();
        
        switch (calculatorChoice)
        {
            case "Basic":
                BasicCalc.AcceptUserInputs("First");
                //Console.Write(userInput);
                BasicCalc.AcceptUserInputs("Second");
                break;
            
            case "Tip":
                //do stuff with TipCalc class
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
