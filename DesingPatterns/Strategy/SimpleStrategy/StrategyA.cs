﻿namespace DesingPatterns.Strategy.SimpleStrategy;

public class StrategyA : IStrategy
{
    public object DoSomething(object data)
    {
        var list = (List<string>)data;
        list.Sort();

        return list;
    }
}
