namespace DesingPatterns.Strategy;

public class StrategyContext
{
    public IStrategy? _strategy;

    public StrategyContext()
    {

    }

    public StrategyContext(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void DoSomeBusinessLogic()
    {
        Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");

        if (_strategy == null) return;

        var result = _strategy.DoSomething(new List<string> { "a", "b", "c", "d", "e" });

        string resultStr = string.Empty;
        foreach (var element in (List<string>)result)
        {
            resultStr += element + ",";
        }

        Console.WriteLine(resultStr);
    }
}
