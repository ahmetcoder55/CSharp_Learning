Console.WriteLine("This is a C# Code.");

//İf
//The if statement executes a block of code only if the specified condition evaluates to true.

int temperature = 25;

if (temperature > 20)
{
    Console.WriteLine("It's a warm day!");
}

//Else
//The else statement provides an alternative block of code that executes when the if condition evaluates to false.

int age = 16;

if (age >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}
else
{
    Console.WriteLine("You are too young to vote.");
}

//Else İf

//When you have multiple conditional pathways, you can use else if to test new conditions sequentially if the previous ones were false.

int score = 85;

if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade: B"); // This will execute
}
else if (score >= 70)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Grade: F");
}

//The Ternary Operator
//The ternary operator is a shorthand way of writing simple if-else statements. It returns a value based on a condition.

int number = 7;
string result = (number % 2 == 0) ? "Even" : "Odd";

Console.WriteLine(result);

/*
  The switch statement selects one of many code blocks to be executed based on a matching value. 
It is often a cleaner alternative to long if-else if chains.
case: Matches a specific value.
break: Exits the switch block immediately once a match is found.
default: Executes if no case matches (similar to else).
*/

int dayOfWeek = 3;

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday"); // This will execute
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

/***************************************************************************************************************
 * In modern C# (C# 8.0+), you can use a more concise syntax called Switch Expressions to return values directly.
 ****************************************************************************************************************/

//Example ****

int dayOfWeek1 = 6;

string dayType = dayOfWeek1 switch
{
    6 => "Saturday",
    7 => "Sunday",
    _ => "Weekday" // The underscore (_) acts as the default case
};

Console.WriteLine(dayType); // Outputs: Saturday