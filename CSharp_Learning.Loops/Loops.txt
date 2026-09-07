Console.WriteLine("This is a C# Code.");

/*
 * --C# Loops--
 * Loops are used to execute a block of code repeatedly as long as a specified condition is met. 
 * They help eliminate repetitive code and automate tasks.
 */

//0 Anatomy of a Loop

/*
 To understand how a loop works, it helps to break it down into its core components
Every standard loop relies on four fundamental parts to control its execution flow:
[Initialization] ---> [Condition Check] (True) ---> [Code Block] ---> [Iteration]
                             |
                          (False)
                             |
                             v
                       [Loop Ends]
1. Initialization (Başlangıç): This sets the starting point for the loop. It usually defines a counter variable and sets its initial value (e.g., int i = 0;). It runs only once when the loop begins.
2. Condition (Koşul): A boolean expression that is evaluated before (or after) each cycle. If the condition is true, the loop body runs. If it is false, the loop stops immediately (e.g., i < 5).
3. Loop Body (Döngü Gövdesi): The actual block of code { ... } that executes repeatedly as long as the condition remains true.
4. Iteration / Update (Güncelleme): This modifies the counter variable after each loop cycle (e.g., i++). Without this update, the condition would never become false, creating an infinite loop that crashes your program.
*/
/*Anatomy Example in a for LoopHere is how these four components map directly to the syntax of a standard for loop:*/
//  [Initialization] ; [Condition] ; [Iteration]
for (int b = 0; b < 5; b++)
{
    // [Loop Body]
    Console.WriteLine("Current index: " + b);
}


//1-  The for Loop (For)

/*
 The for loop is ideal when you know exactly how many times you want to loop through a block of code.
 */

// Loops 5 times from 0 to 4
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}

//1- The Foreach Loop (Foreach)

/*
 2.The foreach Loop 
The foreach loop is used exclusively to loop through elements in an array or a collection (like a List). 
It is safer and more readable because it prevents index errors.
 */

//Example
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

foreach (string car in cars)
{
    Console.WriteLine(car);
}

//3- The While Loop

/*
 The while loop loops through a block of code as long as a specified condition is true. 
 It checks the condition before executing the code block.
 */

//Example

int a = 0;

while (a < 5)
{
    Console.WriteLine(a);
    a++;
}

//4-The do-while Loop

/*
 The do-while loop is a variant of the while loop. 
 It executes the code block once before checking the condition, and then repeats the loop as long as the condition is true. 
 It always runs at least once.
*/

//Example

int z = 0;

do
{
    Console.WriteLine(z);
    z++;
} while (z < 5);

// 5 - Loop Control Statements

/*
 You can control the flow of loops using *break* and *continue*
break: Instantly terminates the loop completely.
continue: Skips the current iteration and moves directly to the next one.
*/

//example

for (int c = 0; c < 10; c++)
{
    if (c == 4)
    {
        continue; // Skips the number 4
    }
    if (c == 7)
    {
        break;    // Stops the loop completely at 7
    }
    Console.WriteLine(c);
}