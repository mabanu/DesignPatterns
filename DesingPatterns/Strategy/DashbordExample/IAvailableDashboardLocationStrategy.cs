namespace DesingPatterns.Strategy.DashbordExample;

internal interface IAvailableDashboardLocationStrategy
{
    DashboardLocation? Find(DashboardLocation startLocation, Dashboard dashboard);
}