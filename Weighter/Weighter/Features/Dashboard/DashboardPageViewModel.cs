using Weighter.Core;

namespace Weighter.Features
{
    public class DashboardPageViewModel : BasePageViewModel, ITabPage
    {
        public DashboardPageViewModel(IBaseService baseService)
            : base(baseService)
        {
        }

        public string TabTitle { get; } = "Dashboard";
        public string TabIcon { get; } = "ic_home";
    }
}
