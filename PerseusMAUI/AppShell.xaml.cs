using PerseusMAUI.Pages;
using PerseusMAUI.Services.Auth;

namespace PerseusMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell(IAuthService authService)
        {
            InitializeComponent();

            _authService = authService;

            RegisterRoutes();
        }


        private readonly IAuthService _authService;


        private async void Lock_Clicked(object sender, EventArgs e)
        {
            await _authService.UnauthorizeAsync();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(AuthPage), typeof(AuthPage));
            //Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}