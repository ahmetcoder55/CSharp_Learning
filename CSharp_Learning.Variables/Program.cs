Console.WriteLine("Hello, This is a C# Code");

//C# Variables

/*
 In software, variables are named storage areas in a computer's temporary memory (RAM) reserved
for storing data,
labeling this data with a name, and reusing it within the program.
*/

/*
 ### Introduction to Variables in C#

In C#, a **variable** is a named storage location in the computer's memory (RAM) used to hold data that can be modified during program execution. 

### 📌 Variable Structure (Syntax)

C# is a **strongly-typed** language. This means you must explicitly declare the data type of a variable before using it. 

csharp

// Structure: [Data Type] [Variable Name] = [Value];
int userAge = 25;

Kodu dikkatli kullanın.

* **Data Type:** Determines the type of data and how much memory space to allocate (e.g., int).
* **Variable Name (Identifier):** The unique name used to access the stored data (e.g., userAge).
* **Assignment Operator (=):** Assigns the value on the right side to the variable on the left side.
* **Value:** The actual data stored inside the variable (e.g., 25).

### 🗂️ Memory Management: Value Types vs. Reference Types

C# data types are divided into two main categories based on how they are stored in memory: 

1. **Value Types (Stored in Stack):** These types store the actual data directly in a fast-access memory area called the **Stack**.
2. **Reference Types (Stored in Heap):** These types store the actual data in the **Heap** memory, while storing the memory address (reference) pointer in the **Stack**.

### 📊 Common C# Data Types (Cheat Sheet)

### 1. Numeric Types

* **int:** Stores whole numbers (integers) without decimals (e.g., 10, -500). This is the most common choice for integers.
* **long:** Stores very large whole numbers (e.g., 9223372036854775807).
* **float:** Stores small fractional numbers. Requires an f or F suffix (e.g., 3.14f).
* **double:** Stores standard, high-precision fractional numbers (e.g., 19.99).
* **decimal:** Highly precise fractional type, ideal for financial and monetary calculations. Requires an m or M suffix (e.g., 100.50m).

### 2. Textual and Character Types

* **char:** Stores a **single character** only. Enclosed in single quotes (e.g., 'A', '7').
* **string:** Stores a sequence of characters (**text**). Enclosed in double quotes (e.g., "Hello GitHub").

### 3. Logical Type

* **bool:** Stores logical states, holding only true or false. Primarily used in conditional statements.

### 💡 Basic Naming Conventions in C#

* Variable names **cannot start with a number** (e.g., 3users is invalid, users3 is valid).
* Names cannot contain **spaces or special characters** (except for the underscore _).
* C# **reserved keywords** (like class, int, static) cannot be used as variable names.
* The C# community standard for naming variables is **camelCase** (e.g., userName, totalPrice). 
*/


// 1. Numeric Types
int userAge = 25;
long worldPopulation = 8000000000L; // 'L' suffix for long literals
float piValue = 3.14f;              // 'f' suffix for float literals
double productPrice = 19.99;        // default for fractional numbers
decimal accountBalance = 1500.75m;  // 'm' suffix for financial/decimal accuracy

// 2. Textual Types
char userGrade = 'A';               // single quotes for char
string repositoryName = "C# Learning Repo"; // double quotes for string

// 3. Logical Type
bool isLessonCompleted = true;

// ==========================================
// OUTPUT TO CONSOLE
// ==========================================
Console.WriteLine("--- C# Variables Demo ---");
Console.WriteLine($"Age: {userAge} (int)");
Console.WriteLine($"World Population: {worldPopulation} (long)");
Console.WriteLine($"Pi: {piValue} (float)");
Console.WriteLine($"Price: ${productPrice} (double)");
Console.WriteLine($"Balance: ${accountBalance} (decimal)");
Console.WriteLine($"Grade: {userGrade} (char)");
Console.WriteLine($"Repository: {repositoryName} (string)");
Console.WriteLine($"Is Completed: {isLessonCompleted} (bool)");

// Preventing the console window from closing instantly
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();

