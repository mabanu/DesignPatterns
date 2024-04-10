using DesingPatterns.Strategy.SimpleStrategy;

namespace DesignPatterns.Tests.Unit;

public class Strategy
{
    [Fact]
    public void Constructor_StrategyA_GetStrategyA()
    {
        var strategy = new StrategyContext();

        strategy.SetStrategy(new StrategyA());

        Assert.Equal("StrategyA", strategy._strategy!.GetType().Name);
    }

    [Fact]
    public void Constructor_StrategyB_GetStrategyB()
    {
        var strategy = new StrategyContext();

        strategy.SetStrategy(new StrategyB());

        Assert.Equal("StrategyB", strategy._strategy!.GetType().Name);
    }
}
