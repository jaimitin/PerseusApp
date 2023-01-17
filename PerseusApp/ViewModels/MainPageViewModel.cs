using Acr.UserDialogs;
using Perseus.App.Services.Auth;
using Perseus.App.Services.Navigation;
using Perseus.App.ViewModels.Base;
using System.Text.Json;

namespace Perseus.App.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IAuthService authService;

        public MainPageViewModel(IUserDialogs dialogs, INavigationService navigationService, IAuthService authService) : base(dialogs, navigationService)
        {
            this.authService = authService;

            Now = DateTime.Now;

            Dispatcher.GetForCurrentThread()?.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Now = DateTime.Now;
                return true;
            });

            User = JsonSerializer.Serialize(this.authService.User);
        }

        private DateTime now;
        public DateTime Now
        {
            get => now;
            set => Set(ref now, value);
        }

        private string? user;
        public string? User
        {
            get => user;
            set => Set(ref user, value);
        }
    }
}
