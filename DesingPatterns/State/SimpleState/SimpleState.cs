namespace DesingPatterns.State.SimpleState
{
    internal class SimpleState
    {
        internal static void AddSimpleState()
        {
            var context = new Context(new ConcreteStateA());

            // Issue requests, which toggles state
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}
