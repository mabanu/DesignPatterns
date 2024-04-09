namespace DesingPatterns.Strategy.DashbordExample
{
    internal class DashboardExample
    {
        internal static void AddDashboardExample()
        {
            Dashboard dashboard = new(5, 5, new BreadthFirstAvailableDashboardLocationStrategy());

            Console.WriteLine("Breath first Available dashboard location strategy\n");

            dashboard.AddItem(1, new DashboardLocation(2, 2));
            dashboard.AddItem(2, new DashboardLocation(2, 2));
            dashboard.AddItem(3, new DashboardLocation(2, 2));
            dashboard.AddItem(4, new DashboardLocation(2, 2));
            dashboard.AddItem(5, new DashboardLocation(2, 2));
            dashboard.AddItem(6, new DashboardLocation(2, 2));

            Console.WriteLine(dashboard);

            Console.WriteLine("Depth first available dashboard location strategy\n");

            Dashboard dashboard1 = new(5, 5, new DepthFirstAvailableDashboardLocationStrategy());

            dashboard1.AddItem(1, new DashboardLocation(2, 2));
            dashboard1.AddItem(2, new DashboardLocation(2, 2));
            dashboard1.AddItem(3, new DashboardLocation(2, 2));
            dashboard1.AddItem(4, new DashboardLocation(2, 2));
            dashboard1.AddItem(5, new DashboardLocation(2, 2));
            dashboard1.AddItem(6, new DashboardLocation(2, 2));

            Console.WriteLine(dashboard1);
        }
    }
}
