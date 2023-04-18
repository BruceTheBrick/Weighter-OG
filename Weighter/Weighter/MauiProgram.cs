namespace Weighter
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UsePrismApp<App>(PrismStartup.Configure)
                .ConfigureFonts(ConfigureFonts);

            return builder.Build();
        }

        private static void ConfigureFonts(IFontCollection fontCollection)
        {
            fontCollection.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fontCollection.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }
    }
}
