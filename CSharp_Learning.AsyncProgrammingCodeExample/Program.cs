using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Breakfast preparation started.");

        // Start fetching data/boiling water in the background
        Task<string> toastTask = ToastBreadAsync();

        // While toast is browning in the background, we can do other work synchronously
        Console.WriteLine("Pouring orange juice into the glass...");

        // Now we wait for the toast to actually finish before we eat
        string toastResult = await toastTask;
        Console.WriteLine(toastResult);

        Console.WriteLine("Breakfast is completely ready!");
    }

    static async Task<string> ToastBreadAsync()
    {
        Console.WriteLine("Putting bread in the toaster...");
        await Task.Delay(2000); // Simulates 2 seconds of toasting
        return "Toast is crispy and ready!";
    }
}
