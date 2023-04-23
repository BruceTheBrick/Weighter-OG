using Weighter.Features;

namespace Weighter
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            // Workaround for: 'Either set MainPage or override CreateWindow.'??
            MainPage ??= new NavigationPage(new SplashPage());
            return base.CreateWindow(activationState);
        }
    }
}
