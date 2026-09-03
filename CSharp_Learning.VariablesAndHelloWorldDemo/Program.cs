//Cafe Registration Application

string name;
string surname;
int age;

Console.Title = "Cafe Registration Application";
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
Console.WriteLine("Welcome to Cafe Registration Application");
Console.WriteLine("Please register for the application.");
Console.Write("Name:");
name= Console.ReadLine();
Console.Write("Surname:");
surname= Console.ReadLine();
Console.Write("Age:");
age = Convert.ToInt32(Console.ReadLine());
string welcomeMessage = $"Name:{name}\n Surname:{surname} \n Age:{age.ToString()}";
Console.WriteLine("Welcome!");
Console.WriteLine(welcomeMessage);
Console.ReadKey();