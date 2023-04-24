using Plugin.Firebase.RemoteConfig;

namespace Weighter.Core
{
    public class FeatureToggleService : IFeatureToggleService
    {
        public async Task Initialise()
        {
            var app = CrossFirebaseRemoteConfig.Current;
            await CrossFirebaseRemoteConfig.Current.EnsureInitializedAsync();
            await CrossFirebaseRemoteConfig.Current.FetchAndActivateAsync();
        }
        
        public bool IsEnabled(string featureName)
        {
            return CrossFirebaseRemoteConfig.Current.GetBoolean(featureName);
        }
    }
}