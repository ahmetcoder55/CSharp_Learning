Console.WriteLine("This is a C# Code.");

/*
 -Arrays and Lists in C#-
 Arrays and Lists are used to store multiple values in a single variable. 
 While they serve a similar purpose, they have key differences in terms of flexibility and memory management.
 */

//1-Arrays

/*
 * An Array is a fixed-size collection of elements of the same data type.
 * Once you define the size of an array, it cannot be changed during runtime.
*/

//Example

// Method 1: Declare and specify size
string[] cars = new string[3];
cars[0] = "Volvo";
cars[1] = "BMW";
cars[2] = "Ford";

// Method 2: Declare and initialize immediately
int[] numbers = { 10, 20, 30, 40, 50 };

//Key Features of Arrays

/*
 *Fixed Size*: You cannot add or remove elements easily after creation.
 *Performance*: Very fast and memory-efficient because they store data in contiguous memory slots.
 *Zero-Indexed*: The first element is always at index 0.
*/


//2-Lists

/*
 A List is a dynamic collection of elements. 
Unlike arrays, lists can grow or shrink automatically as you add or remove items.
 */

//Example

//using System.Collections.Generic; => Required namespace

// Create a dynamic list of strings
List<string> programmingLanguages = new List<string>();

// Adding elements
programmingLanguages.Add("C#");
programmingLanguages.Add("Python");
programmingLanguages.Add("Java");

// Removing an element
programmingLanguages.Remove("Java");


//*Key Features of Lists*
/*
 *Dynamic Size*: You can add, insert, or remove items at any time.
 *Built-in Methods*: Includes helpful methods like .Add(), .Remove(), .Contains(), and .Sort().
 *Flexible*: Ideal when you do not know the exact number of elements beforehand.
 */


/*
 Code Example: Iterating Through Both
 */

// Looping through an Array
int[] grades = { 90, 85, 100 };
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Array Grade: " + grades[i]);
}

// Looping through a List
List<int> dynamicGrades = new List<int> { 90, 85, 100 };
foreach (int grade in dynamicGrades)
{
    Console.WriteLine("List Grade: " + grade);
}

/*Summary: Array vs List*/

/*Feature     Array      List*/

/*Size        Fixed      Dynamic*/

/*Performance Slightlyfaster Slightly slower due to resizing overhead*/