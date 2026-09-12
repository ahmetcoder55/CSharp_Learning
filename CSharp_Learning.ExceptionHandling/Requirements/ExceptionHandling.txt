Console.WriteLine("This is a C# Code.");


//Exception Handling in C#

/*
 An Exception is an unexpected event or error that occurs during the execution of a program (runtime), such as dividing a number by zero or trying to open a file that doesn't exist. 
Exception Handling allows you to catch these errors and handle them gracefully instead of letting the program crash.
 */

//1-The Core Structure
/*C# uses a block of four keywords to manage exceptions: try, catch, finally, and throw.*/

//Example

try
{
    // Code that might cause an error
}
catch (Exception ex)
{
    // Code that runs ONLY if an error occurs inside the try block
}
finally
{
    // Code that ALWAYS runs, regardless of whether an error occurred or not
}


//2-Code Example: Catching Specific Exceptions

/*Instead of catching a generic error, it is a best practice to catch specific exception types so you can give precise feedback to the user.*/

try
{
    Console.Write("Enter a number to divide 100: ");
    int input = int.Parse(Console.ReadLine()); // Might throw FormatException if input is string

    int result = 100 / input; // Might throw DivideByZeroException if input is 0
    Console.WriteLine("Result: " + result);
}
catch (FormatException)
{
    // Runs if the user enters "abc" instead of a number
    Console.WriteLine("Error: Please enter a valid numerical value!");
}
catch (DivideByZeroException)
{
    // Runs if the user enters 0
    Console.WriteLine("Error: You cannot divide a number by zero!");
}
catch (Exception ex)
{
    // Catch-all for any other unexpected errors
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
finally
{
    // This block is perfect for cleanup operations (like closing files or databases)
    Console.WriteLine("Execution of the try-catch block is complete.");
}

//3- The throw Keyword
/*You can manually trigger an exception in your code using the throw keyword when specific business rules are violated.*/

//Example

static void CheckAge(int age)
{
    if (age < 18)
    {
        // Manually throwing an error with a custom message
        throw new ArgumentException("Access denied - You must be at least 18 years old.");
    }
    else
    {
        Console.WriteLine("Access granted!");
    }
}


//Common Built-in Exceptions

//Exception Name               Description

//NullReferenceException       Occurs when you try to use an object variable that has not been initialized (null).

//IndexOutOfRangeException     Occurs when you try to access an array or list index that doesn't exist.

//DivideByZeroException        Occurs when a number is divided by zero.

//FormatException              Occurs when the format of an argument is invalid (e.g., converting "hello" to an int).