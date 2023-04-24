using Weighter.Core;

namespace Weighter.Features
{
    public class WorkoutPageViewModel : BaseTabbedPageViewModel
    {
        public WorkoutPageViewModel(IBaseService baseService)
            : base("Workouts", "ic_dumbell", baseService)
        {
        }
    }
}
