using CSharp_Learning.LINQ.Models;

Console.WriteLine("This is a C# Code.");

//LINQ (Language Integrated Query) in C#

/*LINQ provides a unified syntax to query and manipulate data from different data sources (such as collections, arrays, XML, or databases) directly inside C#. 
 * It eliminates the need for writing complex nested for or foreach loops just to filter or sort data.*/


/*
 There are two ways to write LINQ queries:
1-Method Syntax (Fluent API): Uses extension methods and lambda expressions (=>). (Most Popular)
2-Query Syntax: Looks very similar to traditional SQL
 */


//1. Core LINQ Operations (Examples)

//Let's assume we have a simple list of integers:

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//A- Filtering with *Where*

//Filters a collection based on a specific condition.

//Example

// Method Syntax: Find all even numbers
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
// Result: 2, 4, 6, 8, 10

// Query Syntax alternative:
var evenNumbersQuery = (from n in numbers
                        where n % 2 == 0
                        select n).ToList();


//B-Transforming with *Select*

/*Projects or transforms each element of a collection into a new form.*/

//Example

// Multiply every number by 10
var multipliedNumbers = numbers.Select(n => n * 10).ToList();
// Result: 10, 20, 30, ... 100


//C-Sorting with *OrderBy* and *OrderByDescending*

//Sorts elements in ascending or descending order.

List<string> names = new List<string> { "Charlie", "Alice", "Bob" };

var sortedNames = names.OrderBy(name => name).ToList();
// Result: "Alice", "Bob", "Charlie"

//D-Aggragation Methods

//LINQ provides fast mathematical and statistical operations on your collections:

int totalSum = numbers.Sum();      // Adds all numbers together (55)
double average = numbers.Average(); // Calculates average value (5.5)
int maxNumber = numbers.Max();     // Finds the highest number (10)
int minNumber = numbers.Min();     // Finds the lowest number (1)



//Extracting Elements with *First*, *FirstOrDefault*, and *Single*

//First(): Returns the very first element that matches the condition. Throws an error if no element matches.

//FirstOrDefault(): Returns the first element or a default value (like null or 0) if nothing is found. (Safer to use)

// Find the first number greater than 5
int firstNumber = numbers.First(n => n > 5); // Result: 6




//Complex Example: Querying Objects

//LINQ becomes incredibly powerful when working with lists of custom objects (like a list of Students or Products).



// Inside your code:
List<Product> products = new List<Product>
{
    new Product { Name = "Laptop", Price = 1200, Category = "Electronics" },
    new Product { Name = "Phone", Price = 800, Category = "Electronics" },
    new Product { Name = "Shirt", Price = 30, Category = "Clothing" }
};

// LINQ: Get only Electronics that cost more than $500, sorted by price
var expensiveElectronics = products
    .Where(p => p.Category == "Electronics" && p.Price > 500)
    .OrderBy(p => p.Price)
    .ToList();

foreach (var item in expensiveElectronics)
{
    Console.WriteLine($"{item.Name} - ${item.Price}");
}


