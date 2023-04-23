using Weighter.Core;

namespace Weighter.Features
{
    public class WorkoutPageViewModel : BasePageViewModel, ITabPage
    {
        public WorkoutPageViewModel(IBaseService baseService)
            : base(baseService)
        {
        }


        public string TabTitle { get; } = "Workouts";
        public string TabIcon { get; } = "ic_dumbell";
    }
}
