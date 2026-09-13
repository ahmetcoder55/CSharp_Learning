Console.WriteLine("This is a C# Code.");


//Asynchronous Programming in C#

/*In synchronous programming, code is executed line by line. 
 * If a line of code takes 5 seconds to complete (like downloading a large file or fetching data from a database), the entire program freezes and waits.*/

/*Asynchronous programming solves this problem. 
 * It allows your program to start a time-consuming task and move on to other work while that task runs in the background. 
 * Once the background task finishes, the program comes back to process the result.*/


//1-Key Concepts: Task, async, and await

/*Task: Represents an ongoing operation that will complete in the future. 
 * Think of it as a promise or a receipt for a future result.*/

/*async: A keyword used in the method signature to specify that the method contains asynchronous operations.*/

/*await: A keyword placed before a Task. 
 * It tells the program to pause the execution of this specific method until the background task is done, without freezing the entire application thread.*/

/*Code Example: Synchronous vs. Asynchronous*/

//The Old Way: Synchronous (Blocks the Thread)
void MakeCoffee()
{
    Console.WriteLine("Boiling water started...");
    Thread.Sleep(3000); // Freezes the entire application for 3 seconds!
    Console.WriteLine("Water is ready.");
}


//The Modern Way: Asynchronous (Non-Blocking)

// 1. Notice the 'async' keyword and 'Task' return type
 async Task MakeCoffeeAsync()
{
    Console.WriteLine("Boiling water started...");

    // 2. 'Task.Delay' simulates background work without freezing the program
    // 3. 'await' yields control back to the main thread until this finishes
    await Task.Delay(3000);

    Console.WriteLine("Water is ready.");
}


/*
 Summary: Why Use Async?
Better Performance & Responsiveness: User interfaces (like mobile or desktop apps) don't freeze while loading data.
Scalability: Web servers (like ASP.NET Core) can handle thousands of concurrent requests much more efficiently.
Clean Code: Writing asynchronous code with async/await looks almost identical to writing clean, sequential synchronous code.
 */