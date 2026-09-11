Console.WriteLine("This is a C# Code.");

//Access Modifiers in C#

/*
 Access Modifiers are keywords used to specify the scope
and visibility of classes, methods, fields, and properties. 
They control which parts of your program can access or modify your code, which is essential for data security and Encapsulation.
 */

//-public-
//The code is accessible everywhere—both inside and outside the class, and by other projects (assemblies) that reference your project.
public class User
{
    public string Name; // Anyone can read or change this
}


//-private-
/*
 The code is only accessible inside the same class. This is the default modifier if you don't specify one for class members. 
 It hides sensitive data from the outside world.
 */

public class Age
{
    private string ageNumber; 
}

//-protected-

/*
 The code is accessible inside the same class OR in a class that inherits (child class) from it.
 */

public class Vehicle
{
    protected int EngineId; // Child classes can use this
}

public class Car : Vehicle
{
    public void DisplayId()
    {
        Console.WriteLine(EngineId); // Allowed because Car inherits Vehicle
    }
}

//-internal-

/*
 The code is accessible only within the same project (assembly). 
 It cannot be accessed by code in another project/dll, even if it is imported.
 */

internal class DatabaseHelper
{
    // Only visible to code inside this specific project
}

