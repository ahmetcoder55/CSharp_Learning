Console.WriteLine("This is a C# Code.");

//Object-Oriented Programming (OOP) in C#

/*
Object-Oriented Programming (OOP) is a programming paradigm based on the concept of "objects", which can contain data (in the form of fields/properties) and code (in the form of methods). 
OOP helps to structure software programs into reusable, safe, and modular blueprints.
 */

//1. Classes and Objects

/*
*Class* (Sınıf): A blueprint or template for creating objects. It defines properties (data) and methods (behavior) that the objects will have.
*Object* (Nesne): An instance of a class. When a class is defined, no memory is allocated until an object of that class is created.
 */

//Example
// Creating an Instance (Object) inside Main method
Car myCar = new Car();
myCar.Brand = "Tesla";
myCar.Year = 2024;
myCar.StartEngine(); // Output: Tesla's engine started!
// The Blueprint (Class)
public class Car 
{
    public string Brand;
    public int Year;

    public void StartEngine() 
    {
        Console.WriteLine(Brand + "'s engine started!");
    }
}



//The 4 Pillars of OOP (4 Büyük Temel Prensip)

//Encapsulation 
/*
 Encapsulation means hiding the internal details of an object and restricting direct access.
It protects data from unauthorized modification by using private fields and public properties (getters & setters).
 */

//Example

public class BankAccount
{
    // Hidden from outside access
    private double balance;

    // Accessible via safe property logic
    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0) balance = value;
        }
    }
}


//Inheritance 

/*
 Inheritance allows a new class (Child/Derived class) to inherit fields and methods from an existing class (Parent/Base class). 
This promotes code reusability.
 */


// Parent Class
public class Vehicle
{
    public int Speed = 60;
}

// Child Class inherits Vehicle using the ":" operator
public class Bicycle : Vehicle
{
    public bool HasBell = true;
}

//Polymorphism 

/*
 Polymorphism means "many forms".
It allows a child class to provide a specific implementation of a method that is already defined in its parent class using virtual and override keywords.
 */

public class Animal
{
    public virtual void MakeSound() => Console.WriteLine("Animal sound");
}

public class Dog : Animal
{
    // Overriding the parent method to change its behavior
    public override void MakeSound() => Console.WriteLine("Woof! Woof!");
}


//Abstraction 

/*
 Abstraction is the process of hiding complex implementation details and showing only the essential features to the user.
It is achieved using abstract classes or interfaces.
 */
// Abstract class cannot be instantiated directly
public abstract class Appliance
{
    public abstract void TurnOn(); // No body, must be implemented by child classes
}

public class Oven : Appliance
{
    public override void TurnOn() => Console.WriteLine("Oven is heating up...");
}
