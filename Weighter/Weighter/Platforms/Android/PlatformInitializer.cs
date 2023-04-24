using Microsoft.Maui.LifecycleEvents;
using Plugin.Firebase.Core.Platforms.Android;

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
                events.AddAndroid(droid => droid.OnCreate((activity, _) =>
                {
                    CrossFirebase.Initialize(activity);
                }));
            });
            return builder;
        }
    }
}
