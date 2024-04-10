namespace DesingPatterns.State.SimpleState;

internal class Context(IState state)
{
    private IState _state = state;

    // Gets or sets the state
    public IState State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine("State: " + _state.GetType().Name);
        }
    }
    public void Request()
    {
        _state.Handle(this);
    }
}
