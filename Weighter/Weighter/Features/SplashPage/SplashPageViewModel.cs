using Weighter.Core;

namespace Weighter.Features
{
    public class SplashPageViewModel : BasePageViewModel
    {
        public SplashPageViewModel(IBaseService baseService)
            : base(baseService)
        {
        }

        public override async Task OnNavigatedToAsync(INavigationParameters parameters)
        {
            await base.OnNavigatedToAsync(parameters);
            await Task.Delay(5000);
            var t = await NavigationService.NavigateAsync(nameof(DashboardPage));
        }
    }
}
