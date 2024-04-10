namespace DesingPatterns.State.SimpleState;

internal class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        context.State = new ConcreteStateA();
    }
}