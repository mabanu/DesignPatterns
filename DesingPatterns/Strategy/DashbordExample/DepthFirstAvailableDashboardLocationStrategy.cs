namespace DesingPatterns.Strategy.DashbordExample;

internal class DepthFirstAvailableDashboardLocationStrategy : IAvailableDashboardLocationStrategy
{
    public DashboardLocation? Find(DashboardLocation startLocation, Dashboard dashboard) => Find(startLocation, dashboard, []);

    public DashboardLocation? Find(DashboardLocation startLocation, Dashboard dashboard, HashSet<DashboardLocation> searchedLocations)
    {
        if (searchedLocations.Contains(startLocation))
        {
            return null;
        }

        searchedLocations.Add(startLocation);

        if (!dashboard.IsWithinBounds(startLocation.X, startLocation.Y))
        {
            return null;
        }

        if (!dashboard.HasItem(startLocation))
        {
            return startLocation;
        }

        IEnumerable<DashboardLocation> surroundingLocations =
            [
                startLocation.Add(0, -1),
                startLocation.Add(1, 0),
                startLocation.Add(0, 1),
                startLocation.Add(-1, 0),
            ];

        foreach (DashboardLocation currentLocation in surroundingLocations)
        {
            DashboardLocation? availableLocation = Find(currentLocation, dashboard, searchedLocations);

            if (availableLocation != null)
            {
                return availableLocation;
            }
        }

        return null;
    }
}
