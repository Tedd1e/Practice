using Week1.Core;

internal class Program
{
    // static: Main belongs to the class itself, so the runtime can call it
    // without creating a Program object first.
    // string[] args: any command-line arguments, e.g. dotnet run -- hello
    private static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
    }

    private static List<Reading> Load_readings()
    {
        return new List<Reading>() { 
            new Reading("Bolton", "Mon", 11.2f, 4.1f),
        
        
        };
    }

    private static string Describe()
    {

    }


}
