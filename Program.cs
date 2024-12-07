// // See https://aka.ms/new-console-template for more information
// Console.ForegroundColor = ConsoleColor.DarkBlue;
// Console.WriteLine("Welcome to a wise calculator App");
// Console.ForegroundColor = ConsoleColor.White;
// Console.ResetColor();

// CalculatorInput();
// void CalculatorInput()
// {
//     try
//     {
//         Console.Write("Enter first number: ");
//         double firstNumber = double.Parse(Console.ReadLine()!);
//         Console.Write("Enter operator type (+, -, *, /, %)");
//         string operation = Console.ReadLine()!; 
//         Console.Write("Enter second number: ");
//         double secondNumber = double.Parse(Console.ReadLine()!);

//         double result = CalculatorEngine(firstNumber, secondNumber, operation);

//         Console.WriteLine($"Result of {firstNumber} {operation} {secondNumber} is: {result}");
//     }
//     catch(InvalidOperationException ex)
//     {
//         Console.WriteLine("invalid operation", ex.Message);
//     }

//     catch(FormatException)
//     {
//         Console.WriteLine("An Error Occured");
//     }
//     catch(DivideByZeroException dbze)
//     {
//         Console.WriteLine("cannot devide by Zero", dbze.Message);
//     }
// }
// double CalculatorEngine(double number1, double number2, string operatorArg)
// {
//     double result;
//     switch(operatorArg)
//     {
//         case"+":
//         result = number1 + number2;
//         break;

//          case"-":
//         result = number1 - number2;
//         break;

//          case"*":
//         result = number1 * number2;
//         break;

//          case"/":
//         result = number1 / number2;
//         break;

//          case"%":
//         result = number1 % number2;
//         break;

//         default: throw new InvalidOperationException("operator not recognized!");
//     }
//     return result;
// } 

CalculatorEngine();
void CalculatorEngine()
{
    try
    {
        Console.WriteLine("Choose an option");
        Console.WriteLine("Enter 1 to multiply\nEnter 2 to Add\nEnter 3 to Devide\nEnter 4 to Subtract");
        int userInput = int.Parse(Console.ReadLine()!);
        Console.WriteLine("=================");

        switch (userInput)
        {
            case 1:
                int input1 = Prompt("Enter your first number");
                int input2 = Prompt("Enter your second number");
                double multiplyResult = Multiply(input1, input2);

                break;

            default:
                Console.WriteLine("Not found");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("The result is {0}", ex.Message);
        Console.WriteLine("wetin be this!!");
        Console.WriteLine("Read the instructions");
    }

    float Multiply(int a, int b)
    {
        return a * b;
    }
    int Prompt(string text)
    {
        Console.WriteLine(text);
        bool value = int.TryParse(Console.ReadLine(), out int result);
        return result;
    }
}