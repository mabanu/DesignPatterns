namespace DesingPatterns.State.SimpleState;

internal abstract class State
{
    public abstract void Handle(Context context);
}
