using Weighter.Core;
using Weighter.Features;
using DeviceInfo = Weighter.Core.DeviceInfo;
using IDeviceInfo = Weighter.Core.IDeviceInfo;
using INavigationService = Weighter.Core.INavigationService;

namespace Weighter
{
    internal static class PrismStartup
    {
        public static void Configure(PrismAppBuilder builder)
        {
            builder
                .RegisterTypes(RegisterTypes)
                .RegisterTypes(PlatformInitializer.RegisterTypes)
                .OnAppStart(NavigationConstants.Startup);
        }

        private static void RegisterTypes(IContainerRegistry containerRegistry)
        {
            RegisterNavigation(containerRegistry);
            RegisterServices(containerRegistry);
        }

        private static void RegisterNavigation(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SplashPage, SplashPageViewModel>();
            containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
            containerRegistry.RegisterForNavigation<WorkoutPage, WorkoutPageViewModel>();
            containerRegistry.RegisterForNavigation<NutritionPage, NutritionPageViewModel>();
        }

        private static void RegisterServices(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IBaseService, BaseService>();
            containerRegistry.Register<INavigationService, NavigationService>();
            containerRegistry.Register<IAccessibilityService, AccessibilityService>();
            containerRegistry.Register<IDeviceInfo, DeviceInfo>();
            containerRegistry.Register<ITaskDelay, TaskDelay>();
        }
    }
}
