using Weighter.Core;

namespace Weighter.Features
{
    public class SplashPageViewModel : BasePageViewModel
    {
        private readonly ITaskDelay _taskDelay;
        private readonly IFeatureToggleService _featureToggleService;
        public SplashPageViewModel(
            IFeatureToggleService featureToggleService,
            ITaskDelay taskDelay,
            IBaseService baseService)
            : base(baseService)
        {
            _taskDelay = taskDelay;
            _featureToggleService = featureToggleService;
        }

        public override async Task OnNavigatedToAsync(INavigationParameters parameters)
        {
            try
            {
                await base.OnNavigatedToAsync(parameters);
                await _featureToggleService.Initialise();
                await _taskDelay.Delay(5000);
                await NavigationService.NavigateAsync(NavigationConstants.Dashboard);
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
