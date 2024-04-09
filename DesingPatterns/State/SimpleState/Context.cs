namespace DesingPatterns.State.SimpleState;

internal class Context
{
    State _state;
    // Constructor
    public Context(State state)
    {
        _state = state;
    }
    // Gets or sets the state
    public State State
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
