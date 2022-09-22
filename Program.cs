namespace AdvancedCalculator;

public class Program
{
    static string calculatorChoice; 
    public static string userNumInput1;
    public static string userNumInput2;

    // Main Method
    static void Main(String[] args)
    {
        ChooseCalcType(); //Choose either Basic or Tip
        
        switch (calculatorChoice) //passes value from previous method
        {
            case "Basic":
                BasicCalc.ProcessInputs("First");
                BasicCalc.ProcessInputs("Second");
                BasicCalc.ProcessInputs("Operand");
                break;

            case "Tip":
                //do stuff with TipCalc class
                Console.WriteLine("Tip stuff");
                break;
            
            default:
                Console.WriteLine("Default stuff");
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
