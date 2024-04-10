namespace DesingPatterns.State.SimpleState;

internal interface IState
{
    public void Handle(Context context);
}
