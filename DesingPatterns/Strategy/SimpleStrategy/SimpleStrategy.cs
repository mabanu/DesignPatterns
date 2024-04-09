namespace DesingPatterns.Strategy.SimpleStrategy
{
    internal class SimpleStrategy
    {
        internal static void AddSimpleStrategy()
        {
            var context = new StrategyContext();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new StrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new StrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
