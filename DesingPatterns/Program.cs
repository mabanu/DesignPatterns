using DesingPatterns.State;
using DesingPatterns.Strategy;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DesignPatterns.Tests.Unit")]

// Strategy Pattern
{
    CreateTitle("Strategy Pattern");

    var context = new StrategyContext();

    Console.WriteLine("Client: Strategy is set to normal sorting.");
    context.SetStrategy(new StrategyA());
    context.DoSomeBusinessLogic();

    Console.WriteLine();

    Console.WriteLine("Client: Strategy is set to reverse sorting.");
    context.SetStrategy(new StrategyB());
    context.DoSomeBusinessLogic();

    EndOfTheLine();
}

// State
{
    CreateTitle("State Pattern");

    var context = new Context(new ConcreteStateA());

    // Issue requests, which toggles state
    context.Request();
    context.Request();
    context.Request();
    context.Request();

    EndOfTheLine();
}



void CreateTitle(string title)
{
    Console.ForegroundColor = ConsoleColor.Cyan;

    // Create a separator line
    string separator = new string('=', Console.WindowWidth);

    // Calculate padding for center alignment
    int padding = (Console.WindowWidth - title.Length - 6) / 2;

    // Print the centered title with separators
    Console.WriteLine(separator);
    Console.WriteLine($"|{new string(' ', padding)}{title}{new string(' ', padding)}|");
    Console.WriteLine(separator);

    // Reset console text color
    Console.ResetColor();
}

void EndOfTheLine()
{
    Console.WriteLine("\n");
}