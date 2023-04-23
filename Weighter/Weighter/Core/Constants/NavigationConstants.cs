using Weighter.Features;

namespace Weighter.Core
{
    public static class NavigationConstants
    {
        public const string Startup = $"{nameof(SplashPage)}";

        public const string Dashboard = $"{nameof(TabbedPage)}?createTab={nameof(WorkoutPage)}&createTab={nameof(DashboardPage)}&createTab={nameof(NutritionPage)}?selectedTab={nameof(DashboardPage)}";
    }
}
