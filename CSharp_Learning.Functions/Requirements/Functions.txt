Console.WriteLine("This is a C# Code.");

//Methods/Functions in C#

/*
 A method (also known as a function) is a structured block of code that only runs when it is called. 
 Methods are used to perform specific actions, reuse code without rewriting it, and organize projects into cleaner modules.
 */

//1- Anatomy of a Method

/*
 [Access Modifier] [Return Type] [Method Name] ( [Parameters] ) 
{
    // Method Body (Code to execute)
    return [Value];
}
Access Modifier: Defines the visibility of the method (e.g., public, private, static).
Return Type: The data type of the value the method sends back (e.g., int, string). 
If it returns nothing, use void.
Method Name: The unique name used to call the method. 
It follows PascalCase naming convention in C#.Parameters: Optional inputs passed into the method inside the parentheses.
 */

//2-Types of Methods

// A-Void Methods (No Return Value)

//A method that performs an action but does not return any data.
// Definition
static void SayHello()
{
    Console.WriteLine("Hello, Welcome to my C# project!");
}

// Calling the method
SayHello();

//B - Methods with Parameters
//You can pass data into a method using parameters.

// Definition
static void GreetUser(string username)
{
    Console.WriteLine("Hello, " + username + "!");
}

// Calling the method
GreetUser("Alice"); // Output: Hello, Alice!

//C- Methods that Return a Value

/*
 If you want the method to send data back to where it was called, you specify a return type and use the return keyword.
 */

// Definition
static int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

// Calling the method and saving its result
int result = AddNumbers(5, 10);
Console.WriteLine("The sum is: " + result); // Output: The sum is: 15

//3. Method Overloading

/*
 Method overloading allows you to create multiple methods with the same name, as long as they accept different parameters (different types or different counts).
 */

