using System.ComponentModel;
using Weighter.Core;
using Weighter.Features;

namespace Weighter
{
    public partial class App
    {
        private readonly IThemeService _themeService;
        public App(IThemeService themeService)
        {
            _themeService = themeService;
            InitializeComponent();

            _themeService.PropertyChanged += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, PropertyChangedEventArgs eventArgs)
        {
            if (eventArgs.PropertyName == nameof(_themeService.Theme))
            {
                UpdateTheme();
            }
        }

        private void UpdateTheme()
        {
            var theme = _themeService.Theme;
            if (theme.AppTheme == null)
            {
                return;
            }

            UserAppTheme = theme.AppTheme;
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            // Workaround for: 'Either set MainPage or override CreateWindow.'??
            MainPage ??= new NavigationPage(new SplashPage());
            return base.CreateWindow(activationState);
        }
    }
}
