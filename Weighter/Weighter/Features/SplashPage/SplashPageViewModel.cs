using Weighter.Core;
using Debug = System.Diagnostics.Debug;

namespace Weighter.Features
{
    public class SplashPageViewModel : BasePageViewModel
    {
        private readonly ITaskDelay _taskDelay;
        private readonly IFirebaseInitService _firebaseInitService;
        public SplashPageViewModel(
            IFirebaseInitService firebaseInitService,
            ITaskDelay taskDelay,
            IBaseService baseService)
            : base(baseService)
        {
            _firebaseInitService = firebaseInitService;
            _taskDelay = taskDelay;
        }

        public override async Task OnNavigatedToAsync(INavigationParameters parameters)
        {
            try
            {
                await base.OnNavigatedToAsync(parameters);
                await _firebaseInitService.Initialize();
                await _taskDelay.Delay(5000);
                await NavigationService.NavigateAsync(NavigationConstants.Dashboard);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                await NavigationService.NavigateAsync(NavigationConstants.Dashboard);
            }
        }
    }
}
