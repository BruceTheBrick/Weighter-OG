using System.Windows.Input;
using Weighter.Core;

namespace Weighter.Features.SplashPage
{
    public class SplashPageViewModel : BasePageViewModel
    {
        public SplashPageViewModel(IBaseService baseService)
            : base(baseService)
        {
            NavigateToDashboardCommand = new Command(async => NavigationService.NavigateAsync(nameof(DashboardPage)));
        }

        public ICommand NavigateToDashboardCommand { get; }

        public override Task InitializeAsync(INavigationParameters parameters)
        {
            return base.InitializeAsync(parameters);
        }
    }
}
