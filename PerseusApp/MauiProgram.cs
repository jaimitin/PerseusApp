using Acr.UserDialogs;
using CommunityToolkit.Maui;
using Perseus.App.FontAwesome;
using Perseus.App.Pages;
using Perseus.App.Services.Auth;
using Perseus.App.Services.Navigation;
using Perseus.App.Services.Settings;
using Perseus.App.Services.Theme;
using Perseus.App.ViewModels;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Perseus.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            return MauiApp.CreateBuilder()
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(f =>
                {
                    f.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    f.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    f.AddFont("FontAwesomeBrands.otf", FontAwesomeUtil.Brands);
                    f.AddFont("FontAwesomeRegular.otf", FontAwesomeUtil.Regular);
                    f.AddFont("FontAwesomeSolid.otf", FontAwesomeUtil.Solid);
                })
                .RegisterServices()
                .RegisterViewModels()
                .RegisterPages()
                .Build();
        }

        private static MauiAppBuilder RegisterServices(this MauiAppBuilder b)
        {
            b.Services.AddSingleton(typeof(IFingerprint), CrossFingerprint.Current);
            b.Services.AddSingleton(typeof(IUserDialogs), UserDialogs.Instance);
            b.Services.AddSingleton(typeof(IPreferences), Preferences.Default);
            b.Services.AddSingleton<IAuthService, MockAuthService>();
            b.Services.AddSingleton<IThemeService, ThemeService>();
            b.Services.AddSingleton<INavigationService, NavigationService>();
            b.Services.AddSingleton<ISettingsService, SettingsService>();

            return b;
        }

        private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder b)
        {
            b.Services.AddTransient<AuthPageViewModel>();
            b.Services.AddTransient<MainPageViewModel>();

            return b;
        }

        private static MauiAppBuilder RegisterPages(this MauiAppBuilder b)
        {
            b.Services.AddTransient<AuthPage>();
            b.Services.AddTransient<MainPage>();

            return b;
        }
    }
}
