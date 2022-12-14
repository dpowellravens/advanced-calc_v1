namespace AdvancedCalculator;

public class TipCalc : Program
{
    //public static string userNumInput;

    public static double convertDollarInput;
    public static double convertPercentInput;
    
    public static void CaptureInput(string inputType)
    {
        bool invalid = true;
        bool isNumberParsed = true;

            while (invalid) //Do this while user keeps inputting invalid data.
            {
                //Accept user inputs.
                switch (inputType)
                {
                    case "DollarAmount":
                        Console.WriteLine("Please enter your Dollar Amount (without the $ sign) and hit return.");
                        userDollarAmt = Console.ReadLine();
                        isNumberParsed = double.TryParse(userDollarAmt, out convertDollarInput);
                        break;
                       
                    case "Percentage":
                        Console.WriteLine("Please enter your Percentage Amount (without the parenthesis) and hit return. " +
                                          "Your options are percentages of 18, 20, and 25.");
                        userPercent = Console.ReadLine();
                        isNumberParsed = double.TryParse(userPercent, out convertPercentInput);
            
                        break;
                }
                    //Checking for an invalid number/integer and NULL
                    if ((inputType == "DollarAmount" || inputType == "Percentage") && (!isNumberParsed || convertDollarInput <=0))
                    {
                        Console.WriteLine("You entered a null or invalid number. Please try again.\n");
                        continue;
                    }
                    if ((inputType == "Percentage") &&  ((convertPercentInput != 18) && 
                                                         (convertPercentInput != 20) && 
                                                         (convertPercentInput != 25)))
                    {
                        Console.WriteLine("You entered an invalid Percentage. Please try again.\n");
                        continue;
                    }
                    else
                    {
                        invalid = false;
                    }
            }
            CalculateTip();
    }
    
    static void CalculateTip()
    {
        if (convertDollarInput > 0 && convertPercentInput > 0)
        {
            double calculation = convertDollarInput * (convertPercentInput/100); 
            Console.WriteLine($"{convertPercentInput}% of {convertDollarInput.ToString("C")} is {calculation.ToString("C")} ");
            success = true;
            convertDollarInput = 0;
            convertPercentInput = 0;
            continueAnswerBool = false;
        }
        else
        {
            success = false;
            continueAnswerBool = true;
        }
    }
}            
                
   
