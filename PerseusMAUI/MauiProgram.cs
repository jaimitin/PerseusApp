using Acr.UserDialogs;
using CommunityToolkit.Maui;
using PerseusMAUI.FontAwesome;
using PerseusMAUI.Pages;
using PerseusMAUI.ViewModels;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace PerseusMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp() =>
            MauiApp.CreateBuilder()
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(f =>
                {
                    f.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    f.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    f.AddFont("FontAwesomeBrands.otf", FontAwesomeUtilities.Brands);
                    f.AddFont("FontAwesomeRegular.otf", FontAwesomeUtilities.Regular);
                    f.AddFont("FontAwesomeSolid.otf", FontAwesomeUtilities.Solid);
                })
                .RegisterServices()
                .RegisterViewModels()
                .RegisterPages()
                .Build();

        private static MauiAppBuilder RegisterServices(this MauiAppBuilder b)
        {
            b.Services.AddSingleton(typeof(IFingerprint), CrossFingerprint.Current);
            b.Services.AddSingleton(typeof(IUserDialogs), UserDialogs.Instance);

            return b;
        }

        private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder b)
        {
            b.Services.AddTransient<AuthPageViewModel>();

            return b;
        }

        private static MauiAppBuilder RegisterPages(this MauiAppBuilder b)
        {
            b.Services.AddTransient<AuthPage>();

            return b;
        }
    }
}
