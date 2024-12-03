// Declare variables and then initialize to zero.
using System.Text.RegularExpressions;

double userInputNumberOne;
double userInputNumberTwo;
double result = 0;
string chosenOperation;
string resultMessage = String.Empty;
bool isValidOperation = true;

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");


/* The 'TryParse' function reads the input of the Console.ReadLine. 
 * It returns true if the input matches the data type, and false if not.
 * If it is true, it stores the ReadLine value in a variable (in this case userInputNumberOne)
 */

Console.WriteLine("Please enter first number");
while (!double.TryParse(Console.ReadLine(), out userInputNumberOne))
{
    Console.WriteLine("Invalid input. Please enter a valid number:");
}


Console.WriteLine("Please enter second number");
while (!double.TryParse(Console.ReadLine(), out userInputNumberTwo))
{
    Console.WriteLine("Invalid input. Please enter a valid number:");
}

Console.WriteLine("What operation would you like to perform ( + - / *)?");
chosenOperation = Convert.ToString(Console.ReadLine());

while (chosenOperation == null || !Regex.IsMatch(chosenOperation, "[+|/|*|-]"))
{
    Console.WriteLine("Please enter a valid operation (+ - / *)");
    chosenOperation = Convert.ToString(Console.ReadLine());
}

while (chosenOperation == "/" && userInputNumberTwo == 0)
{
    Console.WriteLine("You can't divide by zero! Choose another operation (+ - *)");
    chosenOperation = Convert.ToString(Console.ReadLine());
}

switch (chosenOperation)
{
    
    case "+":
        result = userInputNumberOne + userInputNumberTwo;
        
        break;

    case "-":
        result = userInputNumberOne - userInputNumberTwo;
        
        break;

    case "*":
        result = userInputNumberOne * userInputNumberTwo;
        
        break;

    case "/":
        result = userInputNumberOne / userInputNumberTwo;
       
        break;

    default:
        Console.WriteLine("Invalid operation!");
        isValidOperation = false;
        break;
}

if (isValidOperation)
{
    resultMessage = $"The result of {userInputNumberOne} {chosenOperation} {userInputNumberTwo} is {result}";
    Console.WriteLine(resultMessage);
}
