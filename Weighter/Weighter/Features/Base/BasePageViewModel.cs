using Weighter.Core;
using INavigationService = Weighter.Core.INavigationService;

namespace Weighter.Features
{
    public class BasePageViewModel : INavigationAware, IInitialize, IInitializeAsync
    {
        public BasePageViewModel(IBaseService baseService)
        {
            NavigationService = baseService.NavigationService;
            AccessibilityService = baseService.AccessibilityService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
        }

        public virtual Task InitializeAsync(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            _ = OnNavigatedToAsync(parameters);
        }

        public virtual Task OnNavigatedToAsync(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
            _ = OnNavigatedFromAsync(parameters);
        }

        public virtual Task OnNavigatedFromAsync(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }

        public INavigationService NavigationService { get; }
        public IAccessibilityService AccessibilityService { get; }
    }
}
