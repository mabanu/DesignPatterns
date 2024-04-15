using DesingPatterns;
using DesingPatterns.CustomClass;
using DesingPatterns.State.SimpleState;
using DesingPatterns.Strategy.DashbordExample;
using DesingPatterns.Strategy.SimpleStrategy;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DesignPatterns.Tests.Unit")]

// Strategy Pattern
{
    ConsoleTemplate.CreateTitle("STRATEGY PATTERN");

    var strategy = new DesingPatternsExample();

    strategy.Examples.AddRange(
        [
            ("Simple Strategy", SimpleStrategy.AddSimpleStrategy),
            ("DashBoard", DashboardExample.AddDashboardExample)
        ]);

    strategy.Run();
}


// State
{
    ConsoleTemplate.CreateTitle("State Pattern");

    var state = new DesingPatternsExample();

    state.Examples.AddRange(
        [
            ("Simple state", SimpleState.AddSimpleState)
        ]);

    state.Run();
}

// Custom class
{
    ConsoleTemplate.CreateTitle("Custom class");

    CustomClassTest.GetCustomClassTest();
}
