using Perseus.App.Services.Auth;
using Perseus.App.Services.Theme;

namespace Perseus.App
{
    public partial class App : Application
    {
        public App(IServiceProvider provider, IAuthService authService, IThemeService themeService)
        {
            InitializeComponent();

            ServiceProvider = provider ?? throw new ArgumentNullException(nameof(provider));

            themeService.Initialize();

            MainPage = new AppShell(authService);
        }

        public static IServiceProvider? ServiceProvider { get; private set; }
    }
}