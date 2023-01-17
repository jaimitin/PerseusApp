using Perseus.App.Pages;
using Perseus.App.Services.Auth;

namespace Perseus.App
{
    public partial class AppShell : Shell
    {
        private readonly IAuthService authService;

        public AppShell(IAuthService authService)
        {
            InitializeComponent();

            this.authService = authService;

            RegisterRoutes();
        }

        private async void Lock_Clicked(object sender, EventArgs e)
        {
            await authService.UnauthorizeAsync();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(AuthPage), typeof(AuthPage));
            Routing.RegisterRoute(nameof(WorkoutTemplateCreatePage), typeof(WorkoutTemplateCreatePage));
            //Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}