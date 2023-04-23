using Weighter.Core;

namespace Weighter.Features
{
    public class NutritionPageViewModel : BasePageViewModel, ITabPage
    {
        public NutritionPageViewModel(IBaseService baseService)
            : base(baseService)
        {
        }

        public string TabTitle { get; } = "Nutrition";
        public string TabIcon { get; } = "ic_food";
    }
}
