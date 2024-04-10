using DesingPatterns.State.SimpleState;

namespace DesignPatterns.Tests.Unit;

public class State
{
    [Fact]
    public void State_CreateContextWithConcretStateA_GetConcretStateA()
    {
        var ctx = new Context(new ConcreteStateA());

        Assert.Equal("ConcreteStateA", ctx.State.GetType().Name);
    }

    [Fact]
    public void State_CallRequest_GetConcretStateB()
    {
        var ctx = new Context(new ConcreteStateA());

        ctx.Request();

        Assert.Equal("ConcreteStateB", ctx.State.GetType().Name);
    }
}
