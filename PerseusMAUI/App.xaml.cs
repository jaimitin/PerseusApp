using PerseusMAUI.Services.Auth;

namespace PerseusMAUI
{
    public partial class App : Application
    {
        public App(IServiceProvider provider, IAuthService authService)
        {
            InitializeComponent();

            ServiceProvider = provider ?? throw new ArgumentNullException(nameof(provider));

            MainPage = new AppShell(authService);
        }

        public static IServiceProvider? ServiceProvider { get; private set; }
    }
}