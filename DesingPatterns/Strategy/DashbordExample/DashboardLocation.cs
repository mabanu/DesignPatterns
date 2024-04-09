namespace DesingPatterns.Strategy.DashbordExample;

internal struct DashboardLocation(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public DashboardLocation Add(int x, int y) => new(X + x, Y + y);
}
