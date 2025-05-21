using Microsoft.Extensions.Logging;

namespace MauiAppHotel1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("DeliusSwashCaps-Regular.ttf", "Delius");
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");

                    fonts.AddFont("Charm-Bold.ttf", "CharmBold");
                    fonts.AddFont("Charm-Regular.ttf", "Charm");

                    fonts.AddFont("CroissantOne - Regular.ttf", "Croissant");

                    fonts.AddFont("PlaywriteTZ-ExtraLight.ttf", "PlaywriteExtra");
                    fonts.AddFont("PlaywriteTZ-Light.ttf", "PlaywriteL");
                    fonts.AddFont("PlaywriteTZ-Regular.ttf", "Playwrite");
                    fonts.AddFont("PlaywriteTZ-Thin.ttf", "PlaywriteR");


                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
