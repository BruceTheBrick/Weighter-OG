namespace Weighter.Core
{
    public interface IFeatureToggleService
    {
        public Task Initialise();
        public bool IsEnabled(string featureName);
    }
}