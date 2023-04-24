using Microsoft.Maui.LifecycleEvents;
using Plugin.Firebase.Core.Platforms.iOS;

namespace Weighter
{
    public static class PlatformInitializer
    {
        public static void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        public static MauiAppBuilder RegisterFirebaseServices(this MauiAppBuilder builder)
        {
            builder.ConfigureLifecycleEvents(events =>
            {
                events.AddiOS(iOS => iOS.FinishedLaunching((app, launchOptions) =>
                {
                    CrossFirebase.Initialize();
                    return false;
                }));
            });
            return builder;
        }
    }
}
